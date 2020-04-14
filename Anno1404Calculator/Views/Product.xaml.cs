using Anno1404Calculator.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
            set { SetValue(ProductTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProductType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductTypeProperty =
            DependencyProperty.Register("ProductType", typeof(Anno1404ProductType), typeof(Product), new PropertyMetadata(Anno1404ProductType.Beer));

        public double ProductConsumption
        {
            get { return (double)GetValue(ProductConsumptionProperty); }
            set { SetValue(ProductConsumptionProperty, value); UpdateEverything(); }
        }

        // Using a DependencyProperty as the backing store for ProductConsumption.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductConsumptionProperty =
            DependencyProperty.Register("ProductConsumption", typeof(double), typeof(Product), new PropertyMetadata(0.0));

        private int _ProductProductions;
        public int ProductProductions
        {
            get => _ProductProductions;
            set
            {
                _ProductProductions = value;
                UpdateEverything();
            }
        }

        private int _ProductProductions25;
        public int ProductProductions25
        {
            get => _ProductProductions25;
            set
            {
                _ProductProductions25 = value;
                UpdateEverything();
            }
        }

        private int _ProductProductions50;
        public int ProductProductions50
        {
            get => _ProductProductions50;
            set
            {
                _ProductProductions50 = value;
                UpdateEverything();
            }
        }

        private int _ProductProductions75;
        public int ProductProductions75
        {
            get => _ProductProductions75;
            set
            {
                _ProductProductions75 = value;
                UpdateEverything();
            }
        }

        public Product()
        {
            this.InitializeComponent();
        }

        private void TextBox_BeforeTextChanging(TextBox _, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
            Debug.WriteLine($"Cancel={args.Cancel}");
        }

        private void UpdateEverything()
        {
            double requiredProductions = ProductType.GetProductionsRequired(ProductConsumption);
            double builtProductions = (ProductProductions * 1.0) + (ProductProductions25 * 1.25) + (ProductProductions50 * 1.5) + (ProductProductions75 * 1.75);
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
}
