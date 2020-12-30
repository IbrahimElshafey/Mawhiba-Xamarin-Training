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


        #region ItemsSource

        public IList ItemsSource
        {
            get => (IList) GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(
                nameof(ItemsSource),
                typeof(IList),
                typeof(RadioButtonGroup),
                default(IList),
                BindingMode.TwoWay,
                propertyChanged: OnItemsSourceChanged);

        static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as RadioButtonGroup)?.ItemsSourceChanged((IList) oldValue, (IList) newValue);
        }

        
        private void ItemsSourceChanged(IList oldValue, IList newValue)
        {
            Children.Clear();
            foreach (var item in newValue)
            {
                var radioButton = new CustomRadioButton()
                {
                    BindingContext = item,
                };
                radioButton.SetBinding(CustomRadioButton.ValueProperty, PropertyToDisplayName);
                radioButton.Changed += (sender, args) =>
                {
                    var oldIndex = ItemsSource.IndexOf(SelectedItem);
                    if(oldIndex!=-1)
                    {
                        var oldSelectedRadioButton = Children[oldIndex] as CustomRadioButton;
                        oldSelectedRadioButton.IsChecked = !oldSelectedRadioButton.IsChecked;
                    }
                    SelectedItem = (sender as CustomRadioButton)?.BindingContext;
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