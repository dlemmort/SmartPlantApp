using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                        Id = Guid.NewGuid(),
                        PlantName = "Aloe Vera",
                        MoistureValue = 54,
                        WaterLevelValue = 80,
                        _moistureLevels = new ObservableCollection<Moisture>
                        {
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,19,55,0),
                                MoistureLevel = 56
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,0,0),
                                MoistureLevel = 46
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,5,0),
                                MoistureLevel = 36
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,10,0),
                                MoistureLevel = 26
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,15,0),
                                MoistureLevel = 16
                            }
                        }
                    },
                    new Plant
                    {
                        Id = Guid.NewGuid(),
                        PlantName = "Alocasia",
                        MoistureValue = 46,
                        WaterLevelValue = 64,
                        _moistureLevels = new ObservableCollection<Moisture>
                        {
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,19,55,0),
                                MoistureLevel = 56
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,0,0),
                                MoistureLevel = 46
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,5,0),
                                MoistureLevel = 36
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,10,0),
                                MoistureLevel = 26
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,15,0),
                                MoistureLevel = 16
                            }
                        }
                    },
                    new Plant
                    {
                        Id = Guid.NewGuid(),
                        PlantName = "Cactus",
                        MoistureValue = 22,
                        WaterLevelValue = 97,
                        _moistureLevels = new ObservableCollection<Moisture>
                        {
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,19,55,0),
                                MoistureLevel = 56
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,0,0),
                                MoistureLevel = 46
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,5,0),
                                MoistureLevel = 36
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,10,0),
                                MoistureLevel = 26
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,15,0),
                                MoistureLevel = 16
                            }
                        }
                    },
                    new Plant
                    {
                        Id = Guid.NewGuid(),
                        PlantName = "Bonsai",
                        MoistureValue = 49,
                        WaterLevelValue = 86,
                        _moistureLevels = new ObservableCollection<Moisture>
                        {
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,19,55,0),
                                MoistureLevel = 56
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,0,0),
                                MoistureLevel = 46
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,5,0),
                                MoistureLevel = 36
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,10,0),
                                MoistureLevel = 26
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,15,0),
                                MoistureLevel = 16
                            }
                        }
                    }
                };
            }
        }

        public static void AddPlant(Plant plant)
        {
            plant.Id = Guid.NewGuid();
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
