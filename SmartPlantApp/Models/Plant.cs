using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SmartPlantApp.Models
{
    public class Plant : INotifyPropertyChanged
    {
        private Guid _id;
        private string _plantName;
        private int _moistureValue;
        private int _waterLevelValue;
        public ObservableCollection<Moisture> _moistureLevels { get; set; }

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string PlantName
        {
            get => _plantName;
            set
            {
                _plantName = value;
                RaisePropertyChanged(nameof(PlantName));
            }
        }

        public int MoistureValue
        {
            get => _moistureValue;
            set
            {
                _moistureValue = value;
                RaisePropertyChanged(nameof(MoistureValue));
            }
        }

        public int WaterLevelValue
        {
            get => _waterLevelValue;
            set
            {
                _waterLevelValue = value;
                RaisePropertyChanged(nameof(WaterLevelValue));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
