using System;
using System.Collections.Generic;
using SmartPlantApp.Models;

namespace SmartPlantApp.Services
{
    public interface IPlantDataService
    {
        List<Plant> GetAllPlants();

        void AddPlant(Plant plant);

        void UpdatePlant(Plant plant);
    }
}
