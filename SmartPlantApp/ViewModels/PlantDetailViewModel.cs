﻿using System;
using System.Windows.Input;
using SmartPlantApp.Models;
using SmartPlantApp.Utility;
using Xamarin.Forms;

namespace SmartPlantApp.ViewModels
{
    public class PlantDetailViewModel : BaseViewModel
    {
        private Plant _selectedPlant;

        public ICommand WaterCommand { get; }

        public ICommand GraphCommand { get; }

        public ICommand EditCommand { get; }

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
            WaterCommand = new Command(OnWaterCommand);
            GraphCommand = new Command(OnGraphCommand);
            EditCommand = new Command(OnEditCommand);
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

        private void OnWaterCommand()
        {

        }

        private void OnGraphCommand()
        {
            App.NavigationService.NavigateTo(ViewNames.PlantGraphView, SelectedPlant);
        }

        private void OnEditCommand()
        {
            App.NavigationService.NavigateTo(ViewNames.PlantEditView, SelectedPlant);
        }
    }
}
