﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPlantApp.Models
{
    public class MockPlantRepository : IPlantRepository
    {
        public List<Plant> Plants { get; set; }

        public MockPlantRepository()
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
                                DateTime = new DateTime(2022,5,28,19,55,0),
                                MoistureLevel = 56
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,29,20,0,0),
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
                                DateTime = new DateTime(2022,5,31,20,10,0),
                                MoistureLevel = 26
                            },
                            new Moisture
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,6,1,20,15,0),
                                MoistureLevel = 16
                            }
                        },
                            _waterLevels = new ObservableCollection<Water>
                            {
                            new Water
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,28,19,55,0),
                                WaterLevel = 30
                            },
                            new Water
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,29,20,0,0),
                                WaterLevel = 20
                            },
                            new Water
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,30,20,5,0),
                                WaterLevel = 90
                            },
                            new Water
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,5,31,20,10,0),
                                WaterLevel = 85
                            },
                            new Water
                            {
                                Id = Guid.NewGuid(),
                                DateTime = new DateTime(2022,6,1,20,15,0),
                                WaterLevel = 84
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

        public async Task<List<Plant>> GetAllPlants()
        {
            return Plants;
        }

        public void UpdatePlant(Plant plant)
        {
            Plant oldPlant = Plants.Where(p => p.Id == plant.Id).FirstOrDefault();
            oldPlant.PlantName = plant.PlantName;
            oldPlant.MoistureValue = plant.MoistureValue;
            oldPlant.WaterLevelValue = plant.WaterLevelValue;
        }
    }
}
