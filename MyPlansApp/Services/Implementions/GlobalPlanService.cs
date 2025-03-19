using System.Net.Http.Json;
using System.Runtime.InteropServices;
using MyPlansApp.Services.Interfaces;
using MyPlansCore.Modul;

namespace MyPlansApp.Services.Implementions
{

    public class GlobalPlanService : IPlanService
    {
        private readonly HttpClient http;
        private readonly IConfiguration configuration;
        private readonly string baseAPI = "";


        public GlobalPlanService(HttpClient http, IConfiguration configuration)
        {
            this.http = http;
            this.configuration = configuration;
            this.baseAPI = configuration["base_api"];
        }


        public async Task addPlanAsync(Plan plan)
        {
            await http.PostAsJsonAsync($"{baseAPI}plans", plan);
        }

        public async Task<List<Plan>> getAllPlansAsync()
        {
            return await http.GetFromJsonAsync<List<Plan>>($"{baseAPI}plans");
        }
    }
}
