
using System.Collections.Generic;
using SmartPlantApp.Models;
using System;
using System.Linq;

namespace SmartPlantApp.ViewModels
{
    public class PlantGraphViewModel : BaseViewModel
    {
        private Plant _selectedPlant;

        private List<Moisture> _moistures;

        public Plant SelectedPlant
        {
            get { return _selectedPlant; }
            set
            {
                _selectedPlant = value;
                OnPropertyChanged("SelectedPlant");
            }
        }

        public List<Moisture> Moistures
        {
            get => _moistures;
            set
            {
                _moistures = value;
            }
        }

        public PlantGraphViewModel()
        {
            SelectedPlant = new Plant();
            Moistures = new List<Moisture>();

        }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
            {
                SelectedPlant = new Plant();
            }
            else
            {
                SelectedPlant = parameter as Plant;
                Moistures = SelectedPlant._moistureLevels.ToList();
            }
                

        }

    }

}
