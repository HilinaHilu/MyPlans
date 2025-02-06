using Blazored.LocalStorage;
using MyPlansApp.Services.Interfaces;
using MyPlansCore.Modul;

namespace MyPlansApp.Services.Implementions
{
    public class LocalPlanService : IPlanService
    {
        public ILocalStorageService localStorageService { get; set; }

        public LocalPlanService(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }

        public async Task addPlanAsync(Plan plan)
        {
            List<Plan> plans = new List<Plan>();
            List<Plan> result = await localStorageService.GetItemAsync<List<Plan>>("plans") ?? new List<Plan>();
            if (result != null) {
                plans = result;
            }
            plans.Add(plan);
            await localStorageService.SetItemAsync("plans", plans);
                
        }

        public async Task<List<Plan>> getAllPlansAsync()
        {
            var result = await localStorageService.GetItemAsync<List<Plan>>("plans");
            if (result != null) {
                return result;
            }
            return new List<Plan>();
        }
    }
}
