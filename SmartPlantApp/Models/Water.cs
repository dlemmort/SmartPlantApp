using System;
using System.ComponentModel;

namespace SmartPlantApp.Models
{
    public class Water : INotifyPropertyChanged
    {
        private Guid _id;
        private DateTime _dateTime;
        private int _waterLevel;

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

        public int WaterLevel
        {
            get => _waterLevel;
            set
            {
                _waterLevel = value;
                RaisePropertyChanged(nameof(WaterLevel));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
