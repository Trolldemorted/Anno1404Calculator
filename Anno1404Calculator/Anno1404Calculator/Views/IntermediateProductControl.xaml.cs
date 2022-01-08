using Anno1404Calculator.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Anno1404Calculator.Views;

public sealed partial class IntermediateProductControl : UserControl
{
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
        set { SetValue(RequiredProductionsProperty, value); }
    }
    public static readonly DependencyProperty RequiredProductionsProperty =
        DependencyProperty.Register("RequiredProductions", typeof(double), typeof(IntermediateProductControl), new PropertyMetadata(0.0));
}
