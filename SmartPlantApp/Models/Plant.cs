using System;
namespace SmartPlantApp.Models
{
    public class Plant
    {
        private int _id;
        private string _plantName;
        private int _moistureValue;
        private int _waterLevelValue;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        public string PlantName
        {
            get => _plantName;
            set
            {
                _plantName = value;
            }
        }

        public int MoistureValue
        {
            get => _moistureValue;
            set
            {
                _moistureValue = value;
            }
        }

        public int WaterLevelValue
        {
            get => _waterLevelValue;
            set
            {
                _waterLevelValue = value;
            }
        }
    }
}
