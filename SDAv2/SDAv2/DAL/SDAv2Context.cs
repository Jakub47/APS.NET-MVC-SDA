using SDAv2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SDAv2.DAL
{
    public class SDAv2Context : DbContext
    {
        public SDAv2Context() : base("SDAv2Context")
            {

        }

        static SDAv2Context()
        {
            Database.SetInitializer<SDAv2Context>(new SDAv2Initializer());
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