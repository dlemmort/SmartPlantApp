using System;
using System.Collections.Generic;
using SmartPlantApp.Models;

namespace SmartPlantApp.Services
{
    public class PlantDataService : IPlantDataService
    {
        public List<Plant> GetAllPlants()
        {
            return MockPlantRepository.Plants;
        }

        public void AddPlant(Plant plant)
        {
            MockPlantRepository.AddPlant(plant);
        }

        public void UpdatePlant(Plant plant)
        {
            MockPlantRepository.UpdatePlant(plant);
        }
    }
}
