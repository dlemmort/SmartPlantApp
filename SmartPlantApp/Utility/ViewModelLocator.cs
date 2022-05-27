using System;
using SmartPlantApp.ViewModels;

namespace SmartPlantApp.Utility
{
    public static class ViewModelLocator
    {
        public static PlantOverviewViewModel PlantOverviewViewModel { get; set; }
            = new PlantOverviewViewModel();

        public static PlantDetailViewModel PlantDetailViewModel { get; set; }
            = new PlantDetailViewModel();
    }
}
