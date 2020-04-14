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
    public sealed partial class CivilizationClass : UserControl
    {
        public uint Amount
        {
            get { return (uint)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Amount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AmountProperty =
            DependencyProperty.Register("Amount", typeof(uint), typeof(CivilizationClass), new PropertyMetadata((uint) 42));



        public string CivClassName
        {
            get { return (string)GetValue(CivClassNameProperty); }
            set { SetValue(CivClassNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CivClassNameProperty =
            DependencyProperty.Register("CivClassName", typeof(string), typeof(CivilizationClass), new PropertyMetadata("civclassname"));

        public CivilizationClass()
        {
            this.InitializeComponent();
        }
    }
}
