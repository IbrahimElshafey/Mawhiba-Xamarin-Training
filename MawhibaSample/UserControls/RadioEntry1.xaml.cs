using System.Collections;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioEntry1
    {
        public RadioEntry1()
        {
            InitializeComponent();
            //Radio button problem
            //https://forums.xamarin.com/discussion/184021/text-of-radio-buttons-not-showing-anymore
        }

        public string GroupName { get; set; }
        public string PropertyToDisplayName { get; set; }

        #region SelectedItem

        public object SelectedItem
        {
            get => GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public static readonly BindableProperty SelectedItemProperty =
            BindableProperty.Create(
                nameof(SelectedItem),
                typeof(object),
                typeof(RadioEntry1),
                default, BindingMode.TwoWay);

        #endregion

        #region ItemsSource

        public IEnumerable ItemsSource
        {
            get => (IEnumerable) GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(
                nameof(ItemsSource),
                typeof(IEnumerable),
                typeof(RadioEntry1),
                default(IEnumerable),
                BindingMode.TwoWay,
                propertyChanged: OnItemsSourceChanged);

        private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as RadioEntry1)?.ItemsSourceChanged((IEnumerable) oldValue, (IEnumerable) newValue);
        }

        private void ItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            Children.Clear();
            foreach (var item in newValue)
            {
                var radioButton = new RadioButton {BindingContext = item};
                radioButton.SetBinding(Button.TextProperty, PropertyToDisplayName);
                radioButton.SetBinding(RadioButton.GroupNameProperty, GroupName);
                radioButton.CheckedChanged += (sender, args) =>
                {
                    SelectedItem = (sender as RadioButton)?.BindingContext;
                };
                Children.Add(radioButton);
            }
        }

        #endregion
    }
}