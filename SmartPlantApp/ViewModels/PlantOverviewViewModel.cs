using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SmartPlantApp.Models;
using Xamarin.Forms;

namespace SmartPlantApp.ViewModels
{
    public class PlantOverviewViewModel : BaseViewModel
    {
        private ObservableCollection<Plant> _plants;

        public ICommand LoadCommand { get; }

        public ICommand AddCommand { get; }

        public ICommand PlantSelectedCommand { get; }

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
            //Plants = new ObservableCollection<Plant>(MockPlantRepository.Plants);
            LoadCommand = new Command(OnLoadCommand);
            AddCommand = new Command(OnAddCommand);
            PlantSelectedCommand = new Command<Plant>(OnPlantSelectedCommand);

        }

        public void OnLoadCommand()
        {
            Plants = new ObservableCollection<Plant>(MockPlantRepository.Plants);
        }

        public void OnAddCommand()
        {

        }

        private void OnPlantSelectedCommand(Plant plant)
        {
            
        }
    }
}
