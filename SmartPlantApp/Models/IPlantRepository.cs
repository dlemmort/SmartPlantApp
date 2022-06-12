using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartPlantApp.Models
{
    public interface IPlantRepository
    {
        Task<List<Plant>> GetAllPlants();

        void UpdatePlant(Plant plant);
    }
}
