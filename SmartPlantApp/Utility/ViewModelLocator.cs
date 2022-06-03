using System;
using SmartPlantApp.ViewModels;
using Xamarin.Forms;

namespace SmartPlantApp.Utility
{
    public static class ViewModelLocator
    {
        public static PlantOverviewViewModel PlantOverviewViewModel { get; set; }
            = new PlantOverviewViewModel();

        public static PlantDetailViewModel PlantDetailViewModel { get; set; }
            = new PlantDetailViewModel();

        public static PlantGraphViewModel PlantGraphViewModel { get; set; }
            = new PlantGraphViewModel();

        public static PlantEditViewModel PlantEditViewModel { get; set; }
            = new PlantEditViewModel();
    }
}
