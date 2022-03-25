using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class Semester  //Table 2 
    {
        public int Id { get; set; }
        //Id must be start from Pascal case if we want to use our custom Id so type [key] before key 
        public int Number { get; set; }
        public string Section { get; set; }
        public int Numberofstudent { get; set; }
        public int RegularStudent { get; set; }
    }
}