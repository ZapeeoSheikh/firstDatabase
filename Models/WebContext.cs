using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class WebContext : DbContext  //DB Handler 
    {
        public WebContext() : base("ConnectionString")
        {


        }
        public DbSet<Project> Projects { get; set; }    //Table
        public DbSet<ProjectStatus> projectStatuses { get; set; } //Table
        public DbSet<Userdetails> Userdetails { get; set; } //Table
        public DbSet<Depertment> Depertments { get; set; } //Table
        public DbSet<Semester> Semesters { get; set; } //Table

    }
}