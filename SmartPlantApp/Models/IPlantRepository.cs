using System;
namespace SmartPlantApp.Models
{
    public interface IPlantRepository
    {
        void AddPlant(Plant plant);
        void UpdatePlant(Plant plant);
    }
}
