using System;
using System.Collections.Generic;
using SmartPlantApp.Utility;
using Xamarin.Forms;

namespace SmartPlantApp.Views
{
    public partial class PlantDetailView : ContentPage
    {
        public PlantDetailView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.PlantDetailViewModel;
        }
    }
}
