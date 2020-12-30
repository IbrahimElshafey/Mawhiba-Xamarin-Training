using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MawhibaSample.UserControls
{
    public class CustomRadioButton : Label
    {
        private readonly TapGestureRecognizer _tapGestureRecognizer;

        public CustomRadioButton()
        {
            FontFamily = "FAR";
            _tapGestureRecognizer = new TapGestureRecognizer
            {
                Command = new Command(ItemClicked)
            };
            GestureRecognizers.Add(_tapGestureRecognizer);
           
        }

        public string CheckedCharacter { get; set; } = "\uf192 ";
        public string UnCheckedCharacter { get; set; } = "\uf111 ";

        public event EventHandler<bool> Changed;

        protected virtual void OnChanged(bool e)
        {
            Changed?.Invoke(this, e);
        }

        private async void ItemClicked()
        {
            await this.ScaleTo(1.05,150);
            IsChecked = !IsChecked;
            await this.ScaleTo(1,150);
            CheckedCommand?.Execute(null);
            OnChanged(IsChecked);
        }

        #region Value

        public string Value
        {
            get => (string) GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(
                nameof(Value),
                typeof(string),
                typeof(CustomRadioButton),
                default(string),
                BindingMode.TwoWay,
                propertyChanged: OnValueChanged);


        private static void OnValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomRadioButton)?.ValueChanged((string) oldValue, (string) newValue);
        }

        private void ValueChanged(string oldValue, string newValue)
        {
            if (oldValue != newValue)
                ReDraw();
        }

        #endregion

        #region CheckedCommand

        public ICommand CheckedCommand
        {
            get => (ICommand) GetValue(CheckedCommandProperty);
            set => SetValue(CheckedCommandProperty, value);
        }

        public static readonly BindableProperty CheckedCommandProperty =
            BindableProperty.Create(
                nameof(CheckedCommand),
                typeof(ICommand),
                typeof(CustomRadioButton),
                default(ICommand),
                BindingMode.TwoWay);
                //propertyChanged: OnCheckedCommandChanged);

        //private static void OnCheckedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    (bindable as CustomRadioButton)?.CheckedCommandChanged((ICommand) oldValue, (ICommand) newValue);
        //}

        //private void CheckedCommandChanged(ICommand oldValue, ICommand newValue)
        //{
        //    _tapGestureRecognizer.Command = newValue;
        //}

        #endregion

        #region IsChecked

        public bool IsChecked
        {
            get => (bool) GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        public static readonly BindableProperty IsCheckedProperty =
            BindableProperty.Create(
                nameof(IsChecked),
                typeof(bool),
                typeof(CustomRadioButton),
                false,
                BindingMode.TwoWay,
                propertyChanged: OnIsCheckedChanged);

        private static void OnIsCheckedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomRadioButton)?.IsCheckedChanged((bool) oldValue, (bool) newValue);
        }

        private void IsCheckedChanged(bool oldValue, bool newValue)
        {
            if(oldValue!=newValue)
                ReDraw();
        }

        #endregion

        private void ReDraw()
        {
            var checkIconSpan = new Span
            {
                Text = IsChecked ? CheckedCharacter : UnCheckedCharacter,
                FontFamily = "FAR",
            };
            var textSpan = new Span
            {
                Text = Value,
                FontFamily = IsChecked ? "TB" : "TR"
            };
            FormattedText = new FormattedString
            {
                Spans =
                {
                    checkIconSpan,
                    textSpan
                }
            };
        }
    }
}