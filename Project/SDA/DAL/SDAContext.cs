using SDA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SDA.DAL
{
    public class SDAContext : DbContext
    {
        public SDAContext() : base("SDAContext")
        {

        }

        static SDAContext()
        {
            Database.SetInitializer<SDAContext>(new SDAInitializer());
        }

        public DbSet<Przedmiot> Przedmiot { get; set; }
        public DbSet<Dormitory> Dormitory { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Ocena> Ocena { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}