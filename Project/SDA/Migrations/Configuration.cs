namespace SDA.Migrations
{
    using SDA.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<SDA.DAL.SDAContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SDA.DAL.SDAContext";
        }

        protected override void Seed(SDA.DAL.SDAContext context)
        {
            SDAInitializer.SeedKursyData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
