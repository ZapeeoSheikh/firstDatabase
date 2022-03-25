using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class WebContext : DbContext
    {
        public WebContext() : base("ConnectionString")
        {


        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> projectStatuses { get; set; }
        public DbSet<Userdetails> Userdetails { get; set; }
    }
}