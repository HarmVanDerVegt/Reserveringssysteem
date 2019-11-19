namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Reserveringssysteem.ReserveringssysteemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Reserveringssysteem.ReserveringssysteemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.BoatTypes.Add(new BoatType("Skiff", 1, false));
            context.BoatTypes.Add(new BoatType("Dubbel Twee", 2, false));
            context.BoatTypes.Add(new BoatType("Twee Zonder", 2, false));
            context.BoatTypes.Add(new BoatType("Twee Met", 2, true));
            context.BoatTypes.Add(new BoatType("Dubbel Vier", 4, false));
            context.BoatTypes.Add(new BoatType("Dubbel Vier Met", 4, true));
            context.BoatTypes.Add(new BoatType("Vier Zonder", 4, false));
            context.BoatTypes.Add(new BoatType("Vier Met", 4, true));
            context.BoatTypes.Add(new BoatType("Acht", 8, true));
            context.SaveChanges();
        }
    }
}
