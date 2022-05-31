using System;
using System.ComponentModel;

namespace SmartPlantApp.Models
{
    public class Moisture : INotifyPropertyChanged
    {
        private Guid _id;
        private DateTime _dateTime;
        private int _moistureLevel;

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
                RaisePropertyChanged(nameof(DateTime));
            }
        }

        public int MoistureLevel
        {
            get => _moistureLevel;
            set
            {
                _moistureLevel = value;
                RaisePropertyChanged(nameof(MoistureLevel));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
