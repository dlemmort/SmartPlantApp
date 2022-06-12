using System;
using SmartPlantApp.Models;
using SmartPlantApp.Services;
using SmartPlantApp.Utility;
using SmartPlantApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPlantApp
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; } = new NavigationService();
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjQ5OTYzQDMyMzAyZTMxMmUzMFZIcGhnaVVtelJndmJKMStCbHB6TXVlWlZjN1NTZlJCbW9ieDRKZTVDQ3c9");
            InitializeComponent();

            DependencyService.Register<IPlantRepository, PlantRepository>();

            NavigationService.Configure(ViewNames.PlantOverviewView, typeof(PlantOverviewView));
            NavigationService.Configure(ViewNames.PlantDetailView, typeof(PlantDetailView));
            NavigationService.Configure(ViewNames.PlantGraphView, typeof(PlantGraphView));
            NavigationService.Configure(ViewNames.PlantEditView, typeof(PlantEditView));
            MainPage = new NavigationPage(new PlantOverviewView())
            {
                BarBackgroundColor = Color.FromHex("#505F4E"),
                BarTextColor = Color.White

            };   
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
