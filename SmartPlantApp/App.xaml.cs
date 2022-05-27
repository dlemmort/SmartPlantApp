using System;
using SmartPlantApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPlantApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PlantOverviewView();
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
