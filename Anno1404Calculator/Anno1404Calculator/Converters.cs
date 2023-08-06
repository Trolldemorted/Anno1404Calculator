namespace Anno1404Calculator;

using Anno1404Calculator.Models;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media.Imaging;
using System;

public class ProductIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is ProductionBuildingEnum intermediateProductType)
        {
            var uri = new Uri("ms-appx:///Assets/BuildingIcons/" + Enum.GetName(typeof(ProductionBuildingEnum), intermediateProductType) + ".png");
            return new BitmapImage(uri);
        }
        throw new InvalidOperationException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}

public class CivilizationIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string civType)
        {
            var uri = new Uri("ms-appx:///Assets/" + civType + ".png");
            return new BitmapImage(uri);
        }
        throw new InvalidOperationException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
