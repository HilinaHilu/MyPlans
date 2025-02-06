using MyPlansCore.Modul;

namespace MyPlansApp.Services.Interfaces
{
    public interface IPlanService
    {
        /// <summary>
        /// Take a plan and add it too storage.
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        Task addPlanAsync(Plan plan);
        /// <summary>
        /// Reurns all plans
        /// </summary>
        /// <returns></returns>
        Task<List<Plan>> getAllPlansAsync();

    }
}
