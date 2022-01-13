using Anno1404Calculator.Models;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace Anno1404Calculator.Views;

public sealed partial class IntermediateProductControl : UserControl
{
    private const double RedThreshold = -2;
    private const double OrangeThreshold = -0.1;
    private const double YellowThreshold = 0;
    private const double LightGreenThreshold = 1;

    public IntermediateProductControl()
    {
        this.InitializeComponent();
    }

    public Anno1404IntermediateBuilding Building
    {
        get { return (Anno1404IntermediateBuilding)GetValue(BuildingProperty); }
        set { SetValue(BuildingProperty, value);}
    }
    public static readonly DependencyProperty BuildingProperty =
        DependencyProperty.Register("Building", typeof(Anno1404IntermediateBuilding), typeof(Anno1404IntermediateBuilding), new PropertyMetadata(Anno1404IntermediateBuilding.Almondplantation));

    public double RequiredProductions
    {
        get { return (double)GetValue(RequiredProductionsProperty); }
        set { SetValue(RequiredProductionsProperty, value); Update(); }
    }
    public static readonly DependencyProperty RequiredProductionsProperty =
        DependencyProperty.Register("RequiredProductions", typeof(double), typeof(IntermediateProductControl), new PropertyMetadata(0.0));

    public int CurrentProductions
    {
        get { return (int)GetValue(CurrentProductionsProperty); }
        set { SetValue(CurrentProductionsProperty, value); Update(); }
    }
    public static readonly DependencyProperty CurrentProductionsProperty =
        DependencyProperty.Register("CurrentProductions", typeof(int), typeof(IntermediateProductControl), new PropertyMetadata(0));

    private void Update()
    {
        double diff = CurrentProductions - RequiredProductions;
        if (diff <= RedThreshold)
        {
            RequiredProductionsPanel.Background = new SolidColorBrush(Colors.Red);
        }
        else if (diff <= OrangeThreshold)
        {
            RequiredProductionsPanel.Background = new SolidColorBrush(Colors.Orange);
        }
        else if (diff <= YellowThreshold)
        {
            RequiredProductionsPanel.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (diff <= LightGreenThreshold)
        {
            RequiredProductionsPanel.Background = new SolidColorBrush(Colors.LightGreen);
        }
        else
        {
            RequiredProductionsPanel.Background = new SolidColorBrush(Colors.Green);
        }
    }
}
