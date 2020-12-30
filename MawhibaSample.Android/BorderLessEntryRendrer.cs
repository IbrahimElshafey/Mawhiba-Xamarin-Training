using System.ComponentModel;
using Android.Content;
using MawhibaSample.Droid;
using MawhibaSample.UserControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderLessEntry), typeof(BorderLessEntryRenderer))]
namespace MawhibaSample.Droid
{
    /// <summary>
    /// EnhancedEntryRenderer
    /// </summary>
    public class BorderLessEntryRenderer : EntryRenderer
    {
        public BorderLessEntryRenderer(Context context) : base(context)
        {
            
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = Resources.GetDrawable(Resource.Drawable.EntryBoder);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var entry = sender as BorderLessEntry;
            if (e.PropertyName == BorderLessEntry.PaddingProperty.PropertyName)
            {
                Control.SetPadding((int)entry.Padding.Left, (int)entry.Padding.Top, (int)entry.Padding.Right, (int)entry.Padding.Bottom);
            }
        }
    }
}
