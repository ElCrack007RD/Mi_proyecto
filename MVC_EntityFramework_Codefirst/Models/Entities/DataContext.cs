
using MVC_EntityFramework_Codefirst.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_EntityFramework_Codefirst.Models.Entities
{
    public class DataContext: DbContext
    {
       public DataContext() : base("Mi_proyecto")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Profession> Profession { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
    }
}