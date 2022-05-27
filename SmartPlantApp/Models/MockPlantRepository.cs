using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartPlantApp.Models
{
    public class MockPlantRepository
    {
        public static List<Plant> Plants { get; set; }

        static MockPlantRepository()
        {
            if (Plants == null)
            {
                Plants = new List<Plant>
                {
                    new Plant
                    {
                        Id = 0,
                        PlantName = "Aloe Vera",
                        MoistureValue = 54,
                        WaterLevelValue = 80
                    },
                    new Plant
                    {
                        Id = 1,
                        PlantName = "Alocasia",
                        MoistureValue = 46,
                        WaterLevelValue = 64
                    },
                    new Plant
                    {
                        Id = 2,
                        PlantName = "Cactus",
                        MoistureValue = 22,
                        WaterLevelValue = 97
                    },
                    new Plant
                    {
                        Id = 3,
                        PlantName = "Bonsai",
                        MoistureValue = 49,
                        WaterLevelValue = 86
                    }
                };
            }
        }

        public static void AddPlant(Plant plant)
        {
            plant.Id = Plants.Count;
            Plants.Add(plant);
        }

        public static void UpdatePlant(Plant plant)
        {
            Plant oldPlant = Plants.Where(p => p.Id == plant.Id).FirstOrDefault();
            oldPlant.PlantName = plant.PlantName;
            oldPlant.MoistureValue = plant.MoistureValue;
            oldPlant.WaterLevelValue = plant.WaterLevelValue;
        }
    }
}
