using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MawhibaSample.XamlExtensions;
using Xamarin.Forms;

namespace MawhibaSample.Converters
{
    public class NullImageConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value ?? ImageFromResourcesExtension.GetImage("logo.png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
