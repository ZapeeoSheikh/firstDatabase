using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class Userdetails
    {
        public int Id { get; set; } /// <summary>
        /// Id must be written in Pascal case, if you want to gave your custom name then must write [key] before your Id property
        /// </summary>
        public string Username { get; set; }

        public string ProjectName { get; set; }
    }
}