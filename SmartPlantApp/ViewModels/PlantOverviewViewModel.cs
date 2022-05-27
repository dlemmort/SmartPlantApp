using System;
using System.Collections.ObjectModel;
using SmartPlantApp.Models;

namespace SmartPlantApp.ViewModels
{
    public class PlantOverviewViewModel : BaseViewModel
    {

        private ObservableCollection<Plant> _plants;

        public ObservableCollection<Plant> Plants
        {
            get => _plants;
            set
            {
                _plants = value;
                OnPropertyChanged("Plants");
            }
        }
        public PlantOverviewViewModel()
        {
            Plants = new ObservableCollection<Plant>(MockPlantRepository.Plants);
        }
    }
}
