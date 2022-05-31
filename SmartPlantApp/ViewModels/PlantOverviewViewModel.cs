﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SmartPlantApp.Models;
using SmartPlantApp.Utility;
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

            MessagingCenter.Subscribe<PlantDetailViewModel, Plant>
                (this, MessageNames.PlantChangedMessage, OnPlantChanged);

        }

        private void OnPlantChanged(PlantDetailViewModel sender, Plant plant)
        {
            Plants = new ObservableCollection<Plant>(App.PlantDataService.GetAllPlants());
        }

        public void OnLoadCommand()
        {
            Plants = new ObservableCollection<Plant>(App.PlantDataService.GetAllPlants());
        }

        public void OnAddCommand()
        {
            App.NavigationService.NavigateTo(ViewNames.PlantDetailView);
        }

        private void OnPlantSelectedCommand(Plant plant)
        {
            App.NavigationService.NavigateTo(ViewNames.PlantDetailView, plant);
        }
    }
}
