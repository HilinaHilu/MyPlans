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
            List<Plan> plans = await localStorageService.GetItemAsync<List<Plan>>("plans") ?? new List<Plan>();
            plans.Add(plan);
            await localStorageService.SetItemAsync("plans", plans);
                
        }

        public Task<List<Plan>> getAllPlansAsync()
        {
            throw new NotImplementedException();
        }
    }
}
