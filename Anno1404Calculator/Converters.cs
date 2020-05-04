using Anno1404Calculator.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace Anno1404Calculator
{
    public class ProductIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is Anno1404ProductType productType)
            {
                var uri = new Uri("ms-appx:///Assets/" + Enum.GetName(typeof(Anno1404ProductType), productType) + ".png");
                return new BitmapImage(uri);
            }
            if (value is Anno1404IntermediateBuilding intermediateProductType)
            {
                var uri = new Uri("ms-appx:///Assets/" + Enum.GetName(typeof(Anno1404IntermediateBuilding), intermediateProductType) + ".png");
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
}
