using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.XamlExtensions
{
    [ContentProperty(nameof(ImageName))]
    class ImageFromResourcesExtension: BindableObject,IMarkupExtension
    {

        #region ImageName

        public string ImageName
        {
            get => (string) GetValue(ImageNameProperty);
            set => SetValue(ImageNameProperty, value);
        }

        public static readonly BindableProperty ImageNameProperty =
            BindableProperty.Create(
                nameof(ImageName),
                typeof(string),
                typeof(ImageFromResourcesExtension),
                default(string), BindingMode.TwoWay);

        #endregion

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return GetImage(ImageName);
           
        }

        public static ImageSource GetImage(string imageName)
        {
            try
            {
                return ImageSource.FromResource($"MawhibaSample.Assets.Images.{imageName}",
                    typeof(ImageFromResourcesExtension).GetTypeInfo().Assembly);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
