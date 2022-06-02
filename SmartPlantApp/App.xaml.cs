using System;
using SmartPlantApp.Services;
using SmartPlantApp.Utility;
using SmartPlantApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPlantApp
{
    public partial class App : Application
    {
        public static PlantDataService PlantDataService { get; } = new PlantDataService();

        public static NavigationService NavigationService { get; } = new NavigationService();
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjQ5OTYzQDMyMzAyZTMxMmUzMFZIcGhnaVVtelJndmJKMStCbHB6TXVlWlZjN1NTZlJCbW9ieDRKZTVDQ3c9");
            InitializeComponent();

            NavigationService.Configure(ViewNames.PlantOverviewView, typeof(PlantOverviewView));
            NavigationService.Configure(ViewNames.PlantDetailView, typeof(PlantDetailView));
            NavigationService.Configure(ViewNames.PlantGraphView, typeof(PlantGraphView));
            MainPage = new NavigationPage(new PlantOverviewView());   
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
