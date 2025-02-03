using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlansCore.Modul
{
   public class Plan
    {
        public string Titlel { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Category category {  get; set; } 
        public DateTime start { get; set; }
        public DateTime end { get; set; }
     
    }

    public enum Category { 
    School,Work,Gym,Studying,Realxing

    }


}
