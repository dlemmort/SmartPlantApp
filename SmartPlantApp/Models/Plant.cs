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
        private int _minMoistureValue;
        private int _maxMoistureValue;
        private int _minWaterLevelValue;
        private int _maxWaterLevelValue;

        public ObservableCollection<Moisture> _moistureLevels { get; set; }
        public ObservableCollection<Water> _waterLevels { get; set; }

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

        public int MinMoistureValue
        {
            get => _minMoistureValue;
            set
            {
                _minMoistureValue = value;
                RaisePropertyChanged(nameof(MinMoistureValue));
            }
        }

        public int MaxMoistureValue
        {
            get => _maxMoistureValue;
            set
            {
                _maxMoistureValue = value;
                RaisePropertyChanged(nameof(MaxMoistureValue));
            }
        }

        public int MinWaterLevelValue
        {
            get => _minWaterLevelValue;
            set
            {
                _minWaterLevelValue = value;
                RaisePropertyChanged(nameof(MaxMoistureValue));
            }
        }

        public int MaxWaterLevelValue
        {
            get => _maxWaterLevelValue;
            set
            {
                _maxWaterLevelValue = value;
                RaisePropertyChanged(nameof(MaxWaterLevelValue));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
