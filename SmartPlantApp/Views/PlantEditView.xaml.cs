using System;
using System.Collections.Generic;
using SmartPlantApp.Utility;
using Xamarin.Forms;

namespace SmartPlantApp.Views
{
    public partial class PlantEditView : ContentPage
    {
        public PlantEditView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.PlantEditViewModel;
        }
    }
}
