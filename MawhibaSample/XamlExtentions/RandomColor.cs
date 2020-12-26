using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.XamlExtensions
{
    public class RandomColor : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var random = new Random();
            return Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}