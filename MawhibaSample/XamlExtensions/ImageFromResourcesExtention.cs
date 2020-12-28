using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.XamlExtensions
{
    [ContentProperty(nameof(ImageName))]
    class ImageFromResourcesExtension:IMarkupExtension
    {
        
        public string ImageName { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource($"MawhibaSample.{ImageName}", typeof(ImageFromResourcesExtension).GetTypeInfo().Assembly);
        }
    }
}
