using MyPlansApp.Services.Interfaces;
using MyPlansCore.Modul;

namespace MyPlansApp.Services.Implementions
{
    public class PlanServiceStub : IPlanService
    {
        private List<Plan> plans = new List<Plan>
        {
            new Plan { Titel = "Morning Yoga", Description = "A peaceful start to the day", category = 0, start = DateTime.Now.AddHours(1), end = DateTime.Now.AddHours(1.5) },
            new Plan { Titel = "Work on Project", Description = "Focus on IT project tasks", category = 0, start = DateTime.Now.AddHours(2), end = DateTime.Now.AddHours(6) },
            new Plan { Titel = "Lunch Break", Description = "Take a break and enjoy lunch", category = 0, start = DateTime.Now.AddHours(6), end = DateTime.Now.AddHours(7) },
            new Plan { Titel = "Study for Exam", Description = "Prepare for the upcoming exam", category = 0, start = DateTime.Now.AddHours(8), end = DateTime.Now.AddHours(12) },
            new Plan { Titel = "Evening Walk", Description = "A refreshing walk around the neighborhood", category = 0, start = DateTime.Now.AddHours(12), end = DateTime.Now.AddHours(13) },
            new Plan { Titel = "Dinner", Description = "Enjoy a nice dinner with family", category = 0, start = DateTime.Now.AddHours(13), end = DateTime.Now.AddHours(14) },
            new Plan { Titel = "Watch a Movie", Description = "Relax with a good movie", category = 0, start = DateTime.Now.AddHours(14), end = DateTime.Now.AddHours(16) },
            new Plan { Titel = "Work on Code", Description = "Continue coding on the web platform project", category = 0, start = DateTime.Now.AddHours(16), end = DateTime.Now.AddHours(20) },
            new Plan { Titel = "Reading", Description = "Relax with a good book", category = 0, start = DateTime.Now.AddHours(20), end = DateTime.Now.AddHours(22) },
            new Plan { Titel = "Plan Tomorrow", Description = "Organize tasks and plan for the next day", category = 0, start = DateTime.Now.AddHours(22), end = DateTime.Now.AddHours(23) },
            new Plan { Titel = "Morning Meditation", Description = "Start the day with calmness and focus", category = 0, start = DateTime.Now.AddDays(1).AddHours(1), end = DateTime.Now.AddDays(1).AddHours(1.5) },
            new Plan { Titel = "Research for Project", Description = "Look into new tools and ideas for the IT project", category = 0, start = DateTime.Now.AddDays(1).AddHours(2), end = DateTime.Now.AddDays(1).AddHours(5) },
            new Plan { Titel = "Lunch with Friends", Description = "Meet up with friends for lunch", category = 0, start = DateTime.Now.AddDays(1).AddHours(6), end = DateTime.Now.AddDays(1).AddHours(7) },
            new Plan { Titel = "Evening Jog", Description = "Get some fresh air with a light jog", category = 0, start = DateTime.Now.AddDays(1).AddHours(8), end = DateTime.Now.AddDays(1).AddHours(9) },
            new Plan { Titel = "Study Group", Description = "Join a study group for exam preparation", category = 0, start = DateTime.Now.AddDays(1).AddHours(9), end = DateTime.Now.AddDays(1).AddHours(12) },
            new Plan { Titel = "Relax at Home", Description = "Take it easy and unwind at home", category = 0, start = DateTime.Now.AddDays(1).AddHours(12), end = DateTime.Now.AddDays(1).AddHours(14) },
            new Plan { Titel = "Movie Night", Description = "Watch a movie with friends or family", category = 0, start = DateTime.Now.AddDays(1).AddHours(14), end = DateTime.Now.AddDays(1).AddHours(16) },
            new Plan { Titel = "Game Time", Description = "Play a fun video game or board game", category = 0, start = DateTime.Now.AddDays(1).AddHours(16), end = DateTime.Now.AddDays(1).AddHours(18) },
            new Plan { Titel = "Study for Project Management Exam", Description = "Prepare for the project management exam", category = 0, start = DateTime.Now.AddDays(1).AddHours(18), end = DateTime.Now.AddDays(1).AddHours(22) },
            new Plan { Titel = "Night Walk", Description = "A calm walk before bed", category = 0, start = DateTime.Now.AddDays(1).AddHours(22), end = DateTime.Now.AddDays(1).AddHours(23) }
        };
        public Task addPlanAsync(Plan plan)
        {
            plans.Add(plan);
            return Task.CompletedTask;
        }

        public Task<List<Plan>> getAllPlansAsync()
        {
            return Task.FromResult(plans);
        }
    }
}
