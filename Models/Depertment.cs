using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class Depertment  //Table 
    {
        public int Id { get; set; }  //Column 
        public string Title { get; set; } //Column
        public int Teachers { get; set; } //Column
        public int Students { get; set; } //Column
        public string Address { get; set; } //Column
    }
}