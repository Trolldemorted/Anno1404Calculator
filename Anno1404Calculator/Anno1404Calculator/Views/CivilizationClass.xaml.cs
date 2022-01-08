namespace Anno1404Calculator.Views;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

public sealed partial class CivilizationClass : UserControl
{
    public uint Amount
    {
        get { return (uint)GetValue(AmountProperty); }
        set { SetValue(AmountProperty, value); }
    }

    public static readonly DependencyProperty AmountProperty =
        DependencyProperty.Register("Amount", typeof(uint), typeof(CivilizationClass), new PropertyMetadata((uint) 42));

    public string CivClassName
    {
        get { return (string)GetValue(CivClassNameProperty); }
        set { SetValue(CivClassNameProperty, value); }
    }

    public static readonly DependencyProperty CivClassNameProperty =
        DependencyProperty.Register("CivClassName", typeof(string), typeof(CivilizationClass), new PropertyMetadata("civclassname"));

    public CivilizationClass()
    {
        this.InitializeComponent();
    }
}
