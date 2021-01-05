using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using MawhibaSample.Annotations;

namespace MawhibaSample.ViewModels
{
    public class TestVm : INotifyPropertyChanged
    {
        private List<string> _cities;
        private string _city;
        private string _country;
        public List<string> Countries => new List<string>(new[] {"Egypt", "Saudi Arabia", "Germany"});

        public List<string> Cities
        {
            get => _cities;
            set
            {
                if (value == _cities) return;
                _cities = value;
                OnPropertyChanged();
            }
        }

        public string Country
        {
            get => _country;
            set
            {
                if (value == _country) return;
                _country = value;
                OnPropertyChanged();
                ReFillCitiesList();
            }
        }

        public string City
        {
            get => _city;
            set
            {
                if (value == _city) return;
                _city = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ReFillCitiesList()
        {
            switch (Country)
            {
                case "Egypt":
                    Cities = new List<string>(new[] {"City 1", "City 2", "City 3"});
                    break;
                case "Saudi Arabia":
                    Cities = new List<string>(new[] {"City 4", "City 5", "City 6"});
                    break;
                case "Germany":
                    Cities = new List<string>(new[] {"City 7", "City 8", "City 9"});
                    break;
            }

            City = Cities?.First();
        }
    }
}