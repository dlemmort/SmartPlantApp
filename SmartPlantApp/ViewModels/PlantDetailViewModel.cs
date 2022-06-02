using System;
using System.Windows.Input;
using SmartPlantApp.Models;
using SmartPlantApp.Utility;
using Xamarin.Forms;

namespace SmartPlantApp.ViewModels
{
    public class PlantDetailViewModel : BaseViewModel
    {
        private Plant _selectedPlant;

        public ICommand SaveCommand { get; }

        public ICommand GraphCommand { get; }

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
            SaveCommand = new Command(OnSaveCommand);
            GraphCommand = new Command(OnGraphCommand);
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
            if (SelectedPlant.Id == Guid.Empty)
                App.PlantDataService.AddPlant(SelectedPlant);
            else
                App.PlantDataService.UpdatePlant(SelectedPlant);

            MessagingCenter.Send(this, MessageNames.PlantChangedMessage, SelectedPlant);

            App.NavigationService.GoBack();
        }

        private void OnGraphCommand()
        {
            App.NavigationService.NavigateTo(ViewNames.PlantGraphView, SelectedPlant);
        }
    }
}
