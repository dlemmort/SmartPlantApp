using System;
using System.Windows.Input;
using SmartPlantApp.Models;
using Xamarin.Forms;

namespace SmartPlantApp.ViewModels
{
    public class PlantEditViewModel : BaseViewModel
    {
        private Plant _selectedPlant;

        public ICommand SaveCommand { get; }

        public Plant SelectedPlant
        {
            get { return _selectedPlant; }
            set
            {
                _selectedPlant = value;
                OnPropertyChanged("SelectedPlant");
            }
        }

        public PlantEditViewModel()
        {
            SelectedPlant = new Plant();
            SaveCommand = new Command(OnSaveCommand);
        }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
            {
                SelectedPlant = new Plant();
            }
            else
                SelectedPlant = parameter as Plant;
        }

        private void OnSaveCommand()
        {

        }



    }
}
