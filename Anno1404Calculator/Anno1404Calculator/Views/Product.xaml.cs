namespace Anno1404Calculator.Views;

using Anno1404Calculator.Models;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System.Linq;

public sealed partial class Product : UserControl
{
    private const double RedThreshold = -2;
    private const double OrangeThreshold = -0.1;
    private const double YellowThreshold = 0;
    private const double LightGreenThreshold = 1;
    public ProductIconConverter ProductIconConverter { get; set; } = new ProductIconConverter();

    public Anno1404ProductType ProductType
    {
        get { return (Anno1404ProductType)GetValue(ProductTypeProperty); }
        set  { SetValue(ProductTypeProperty, value); }
    }
    public static readonly DependencyProperty ProductTypeProperty =
        DependencyProperty.Register("ProductType", typeof(Anno1404ProductType), typeof(Product), new PropertyMetadata(Anno1404ProductType.Beer));

    public double ProductConsumption
    {
        get { return (double)GetValue(ProductConsumptionProperty); }
        set { SetValue(ProductConsumptionProperty, value); UpdateEverything(); }
    }
    public static readonly DependencyProperty ProductConsumptionProperty =
        DependencyProperty.Register("ProductConsumption", typeof(double), typeof(Product), new PropertyMetadata(0.0));

    public uint ProductProductions00
    {
        get { return (uint)GetValue(ProductProductions00Property); }
        set { SetValue(ProductProductions00Property, value); UpdateEverything(); }
    }
    public static readonly DependencyProperty ProductProductions00Property =
        DependencyProperty.Register("ProductProductions00", typeof(uint), typeof(Product), new PropertyMetadata((uint)0));

    public uint ProductProductions25
    {
        get { return (uint)GetValue(ProductProductions25Property); }
        set { SetValue(ProductProductions25Property, value); UpdateEverything(); }
    }
    public static readonly DependencyProperty ProductProductions25Property =
        DependencyProperty.Register("ProductProductions25", typeof(uint), typeof(Product), new PropertyMetadata((uint)0));

    public uint ProductProductions50
    {
        get { return (uint)GetValue(ProductProductions50Property); }
        set { SetValue(ProductProductions50Property, value);  UpdateEverything(); }
    }
    public static readonly DependencyProperty ProductProductions50Property =
        DependencyProperty.Register("ProductProductions50", typeof(uint), typeof(Product), new PropertyMetadata((uint)0));

    public uint ProductProductions75
    {
        get { return (uint)GetValue(ProductProductions75Property); }
        set { SetValue(ProductProductions75Property, value); UpdateEverything(); }
    }
    public static readonly DependencyProperty ProductProductions75Property =
        DependencyProperty.Register("ProductProductions75", typeof(uint), typeof(Product), new PropertyMetadata((uint)0));

    public Product()
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
        double requiredProductions = ProductType.GetProductionsRequired(ProductConsumption);
        double builtProductions = (ProductProductions00 * 1.0) + (ProductProductions25 * 1.25) + (ProductProductions50 * 1.5) + (ProductProductions75 * 1.75);
        double surplusProductions = builtProductions - requiredProductions;
        if (surplusProductions <= RedThreshold)
        {
            ConsumptionBorder.Background = new SolidColorBrush(Colors.Red);
        }
        else if (surplusProductions <= OrangeThreshold)
        {
            ConsumptionBorder.Background = new SolidColorBrush(Colors.Orange);
        }
        else if (surplusProductions <= YellowThreshold)
        {
            ConsumptionBorder.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (surplusProductions <= LightGreenThreshold)
        {
            ConsumptionBorder.Background = new SolidColorBrush(Colors.LightGreen);
        }
        else
        {
            ConsumptionBorder.Background = new SolidColorBrush(Colors.Green);
        }
        ProductProductionsRequired.Text = string.Format("{0:0.00}", requiredProductions);
    }
}
