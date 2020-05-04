using Anno1404Calculator.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace Anno1404Calculator.Views
{
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
}
