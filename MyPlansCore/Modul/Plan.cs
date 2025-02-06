using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlansCore.Modul
{
   public class Plan
    {
        public string Titel { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Category category { get; set; } = Category.Realxing;
        public DateTime start { get; set; } = DateTime.Now;
        public DateTime end { get; set; } = DateTime.Now;
     
    }

    public enum Category { 
    School,Work,Gym,Studying,Realxing

    }


}
