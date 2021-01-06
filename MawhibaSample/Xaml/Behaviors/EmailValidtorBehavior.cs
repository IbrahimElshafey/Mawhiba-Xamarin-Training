using System.Net.Mail;
using Xamarin.Forms;

namespace MawhibaSample.Xaml.Behaviors
{
    internal class EmailValidatorBehavior : Behavior<Entry>
    {
        private Entry _entry;

        protected override void OnAttachedTo(Entry bindable)
        {
            _entry = bindable;
            bindable.TextChanged += Entry_TextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= Entry_TextChanged;
            base.OnDetachingFrom(bindable);
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var mailAddress = new MailAddress(_entry.Text);
                if (mailAddress.Address == _entry.Text)
                    _entry.Background = Brush.White;
            }
            catch
            {
                _entry.Background = Brush.OrangeRed;
            }
        }
    }
}