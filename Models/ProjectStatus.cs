using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class ProjectStatus  // table 4
    {
        public int Id { get; set; } 
        public string ProjectTitle { get; set; }    
        
        public int Status { get; set; }

        public int Cost { get; set; }
        public int Marks { get; set; }
    }
}