using System;
using System.Collections.Generic;
using SmartPlantApp.Utility;
using Xamarin.Forms;

namespace SmartPlantApp.Views
{
    public partial class PlantOverviewView : ContentPage
    {
        public PlantOverviewView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.PlantOverviewViewModel;
        }
    }
}
