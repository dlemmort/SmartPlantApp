﻿using System;
using Xamarin.Forms;

namespace SmartPlantApp.Services
{
    public interface INavigationService
    {
        Page MainPage { get; }

        void Configure(string key, Type pageType);

        void GoBack();

        void NavigateTo(string pageKey, object parameter = null);
    }
}
