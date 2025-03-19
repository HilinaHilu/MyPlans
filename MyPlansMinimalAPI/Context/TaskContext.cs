using System.Diagnostics.Eventing.Reader;
using Microsoft.EntityFrameworkCore;
using MyPlansCore.Modul;
namespace MyPlansMinimalAPI.Context
{
    public class TaskContext : DbContext
    {
        public DbSet<Plan> Plans => Set<Plan>();
    
        public TaskContext(DbContextOptions<TaskContext> options)
              : base(options)
        {
            // Den her er tom. Men ": base(options)" sikre at constructor
            // på DbContext super-klassen bliver kaldt.
        }
    }
}