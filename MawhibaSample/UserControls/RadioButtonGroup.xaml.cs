using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioButtonGroup
    {
        
        public RadioButtonGroup()
        {
            InitializeComponent();
            //Todo[29/12/2020][Ibrahim]:create properties
            //SelectedItem = "{Binding SelectedRadio}"
        }

        public string PropertyToDisplayName { get; set; }
        public string GroupName { get; set; }


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
                typeof(RadioButtonGroup),
                default(IEnumerable),
                BindingMode.TwoWay,
                propertyChanged: OnItemsSourceChanged);

        static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as RadioButtonGroup)?.ItemsSourceChanged((IEnumerable) oldValue, (IEnumerable) newValue);
        }

        private void ItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            Children.Clear();
            foreach (var item in newValue)
            {
                var radioButton = new RadioButton
                {
                    GroupName = GroupName,
                    BindingContext = item,
                };
                radioButton.SetBinding(Button.TextProperty,PropertyToDisplayName);
                radioButton.CheckedChanged += (sender, args) =>
                {
                    SelectedItem = (sender as RadioButton)?.BindingContext;
                };
                Children.Add(radioButton);
            }
        }

        #endregion

        #region SelectedItem

        public object SelectedItem
        {
            get => (object) GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public static readonly BindableProperty SelectedItemProperty =
            BindableProperty.Create(
                nameof(SelectedItem),
                typeof(object),
                typeof(RadioButtonGroup),
                default(object), BindingMode.TwoWay);

        #endregion

    }
}