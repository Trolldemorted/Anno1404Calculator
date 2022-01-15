namespace Anno1404Calculator.Views;

using Anno1404Calculator.Models;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Diagnostics;
using System.Linq;

public sealed partial class ProductionBuildingControl : UserControl
{
    private const double RedThreshold = -2;
    private const double OrangeThreshold = -0.1;
    private const double YellowThreshold = 0;
    private const double LightGreenThreshold = 1;
    public ProductIconConverter ProductIconConverter { get; set; } = new ProductIconConverter();

    public AnnoPlayerStatus? PlayerStatus
    {
        get { return (AnnoPlayerStatus)GetValue(PlayerStatusProperty); }
        set { SetValue(PlayerStatusProperty, value); UpdateEverything(); }
    }
    public static readonly DependencyProperty PlayerStatusProperty =
        DependencyProperty.Register("PlayerStatus", typeof(AnnoPlayerStatus), typeof(ProductionBuildingControl), new PropertyMetadata(new AnnoPlayerStatus()));

    public ProductionBuildingEnum ProductionBuildingType
    {
        get { return (ProductionBuildingEnum)GetValue(BuildingTypeProperty); }
        set { SetValue(BuildingTypeProperty, value); }
    }
    public static readonly DependencyProperty BuildingTypeProperty =
        DependencyProperty.Register("ProductionBuildingType", typeof(ProductionBuildingEnum), typeof(ProductionBuildingControl), new PropertyMetadata(ProductionBuildingEnum.Cropfarm));

    public bool IsBuffable
    {
        get { return (bool)GetValue(IsBuffableProperty); }
        set
        {
            SetValue(IsBuffableProperty, value);
            if (value)
            {
                Buildings00.Visibility = Visibility.Visible;
                Buildings25.Visibility = Visibility.Visible;
                Buildings50.Visibility = Visibility.Visible;
                Buildings75.Visibility = Visibility.Visible;
            }
            else
            {
                Buildings00.Visibility = Visibility.Collapsed;
                Buildings25.Visibility = Visibility.Collapsed;
                Buildings50.Visibility = Visibility.Collapsed;
                Buildings75.Visibility = Visibility.Collapsed;
            }
        }
    }
    public static readonly DependencyProperty IsBuffableProperty =
        DependencyProperty.Register("IsBuffable", typeof(bool), typeof(ProductionBuildingControl), new PropertyMetadata(false));

    public uint ProductProductions00
    {
        get { return (uint)GetValue(ProductProductions00Property); }
        set { SetValue(ProductProductions00Property, value); }
    }
    public static readonly DependencyProperty ProductProductions00Property =
        DependencyProperty.Register("ProductProductions00", typeof(uint), typeof(ProductionBuildingControl), new PropertyMetadata((uint)0));

    public uint ProductProductions25
    {
        get { return (uint)GetValue(ProductProductions25Property); }
        set { SetValue(ProductProductions25Property, value); }
    }
    public static readonly DependencyProperty ProductProductions25Property =
        DependencyProperty.Register("ProductProductions25", typeof(uint), typeof(ProductionBuildingControl), new PropertyMetadata((uint)0));

    public uint ProductProductions50
    {
        get { return (uint)GetValue(ProductProductions50Property); }
        set { SetValue(ProductProductions50Property, value); }
    }
    public static readonly DependencyProperty ProductProductions50Property =
        DependencyProperty.Register("ProductProductions50", typeof(uint), typeof(ProductionBuildingControl), new PropertyMetadata((uint)0));

    public uint ProductProductions75
    {
        get { return (uint)GetValue(ProductProductions75Property); }
        set { SetValue(ProductProductions75Property, value); }
    }
    public static readonly DependencyProperty ProductProductions75Property =
        DependencyProperty.Register("ProductProductions75", typeof(uint), typeof(ProductionBuildingControl), new PropertyMetadata((uint)0));

    public ProductionBuildingControl()
    {
        this.InitializeComponent();
    }

    private void TextBox_BeforeTextChanging(TextBox _, TextBoxBeforeTextChangingEventArgs args)
    {
        args.Cancel = args.NewText.Any(c => !char.IsDigit(c)) && args.NewText != string.Empty;
    }

    private void TextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
    {
        var pos = sender.SelectionStart;
        var trimmed = TrimInput(sender.Text);
        var diff = sender.Text.Length - trimmed.Length;
        sender.Text = trimmed;
        sender.SelectionStart = pos - diff;
        if (sender.Text == "0")
        {
            sender.SelectionStart = 1;
        }
    }

    private string TrimInput(string value)
    {
        var trimmed = value.TrimStart('0');
        if (trimmed == string.Empty)
        {
            return "0";
        }
        return trimmed;
    }

    private void UpdateEverything()
    {
        if (PlayerStatus != null)
        {
            uint totalBuildings = PlayerStatus.GetBuildingCount(ProductionBuildingType);
            double production = ProductionBuildingType.GetPlayerProductionPerMinute(PlayerStatus, totalBuildings, ProductProductions00, ProductProductions25, ProductProductions50, ProductProductions75);
            double consumption = ProductionBuildingType.GetConsumptionPerMinute(PlayerStatus);
            double surplus = production - consumption;
            double surplusUnbuffedBuildings = surplus / ProductionBuildingType.GetProductionPerMinute();

            if (surplusUnbuffedBuildings <= RedThreshold)
            {
                ProductionTextBlockGrid.Background = new SolidColorBrush(Colors.Red);
            }
            else if (surplusUnbuffedBuildings <= OrangeThreshold)
            {
                ProductionTextBlockGrid.Background = new SolidColorBrush(Colors.Orange);
            }
            else if (surplusUnbuffedBuildings <= YellowThreshold)
            {
                ProductionTextBlockGrid.Background = new SolidColorBrush(Colors.Yellow);
            }
            else if (surplusUnbuffedBuildings <= LightGreenThreshold)
            {
                ProductionTextBlockGrid.Background = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                ProductionTextBlockGrid.Background = new SolidColorBrush(Colors.Green);
            }

            if (totalBuildings < ProductProductions00 + ProductProductions25 + ProductProductions50 + ProductProductions75)
            {
                TotalBuildingsGrid.Background = new SolidColorBrush(Colors.OrangeRed);
            }
            else
            {
                TotalBuildingsGrid.Background = this.Background;
            }

            ConsumptionTextBlock.Text = $"{consumption:0.00}";
            ProductionTextBlock.Text = $"{production:0.00}";
            TotalBuildingsTextBlock.Text = $"{totalBuildings}";
        }
    }
}
