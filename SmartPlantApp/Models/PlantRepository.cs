using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SmartPlantApp.Services;

namespace SmartPlantApp.Models
{
    public class PlantRepository : IPlantRepository
    {
        public List<Plant> Plants { get; set; }
        HttpClient client;
        const String url = "http://localhost:5156/api/Plant";

        public PlantRepository()
        {
            client = new HttpClient();
        }

        public void UpdatePlant(Plant plant)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Plant>> GetAllPlants()
        {
            var response = await client.GetStringAsync(url);
            List<Plant> plants = JsonConvert.DeserializeObject<List<Plant>>(response);
            return plants;
        }
    }
}
