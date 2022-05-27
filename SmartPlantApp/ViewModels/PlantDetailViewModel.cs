using System;
using SmartPlantApp.Models;

namespace SmartPlantApp.ViewModels
{
    public class PlantDetailViewModel : BaseViewModel
    {
        private Plant _selectedPlant;

        public Plant SelectedPlant
        {
            get { return _selectedPlant; }
            set
            {
                _selectedPlant = value;
                OnPropertyChanged("SelectedPlant");
            }
        }

        public PlantDetailViewModel()
        {
            SelectedPlant = new Plant();
        }
    }
}
