using Xamarin.Forms;

namespace MawhibaSample.UserControls
{
    public class BorderLessEntry : Entry
    {
        #region Padding

        public Thickness Padding
        {
            get => (Thickness) GetValue(PaddingProperty);
            set => SetValue(PaddingProperty, value);
        }

        public static readonly BindableProperty PaddingProperty =
            BindableProperty.Create(
                nameof(Padding),
                typeof(Thickness),
                typeof(BorderLessEntry),
                new Thickness(5), BindingMode.TwoWay);

        #endregion

    }
}