using Xamarin.Forms;

using System;
using System.Collections.Generic;
using SmartPlantApp.Utility;
using Xamarin.Forms;

namespace SmartPlantApp.Views
{
    public partial class PlantGraphView : ContentPage
    {
        public PlantGraphView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.PlantGraphViewModel;
            
        }
    }
}
