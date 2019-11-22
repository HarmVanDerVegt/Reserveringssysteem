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

            context.BoatTypes.RemoveRange(context.BoatTypes);
            context.Certificates.RemoveRange(context.Certificates);
            context.Users.RemoveRange(context.Users);

            context.BoatTypes.AddOrUpdate(new BoatType("Skiff", 1, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Dubbel Twee", 2, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Twee Zonder", 2, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Twee Met", 2, true));
            context.BoatTypes.AddOrUpdate(new BoatType("Dubbel Vier", 4, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Dubbel Vier Met", 4, true));
            context.BoatTypes.AddOrUpdate(new BoatType("Vier Zonder", 4, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Vier Met", 4, true));
            context.BoatTypes.AddOrUpdate(new BoatType("Acht", 8, true));


            Boat test = new Boat(new BoatType("brokenBoat", 2, false));
            test.BoatStatus = BoatStatus.Broken;
            context.Boats.AddOrUpdate(test);

            Reservation r = new Reservation(new Boat(new BoatType("Skiff", 1, false)), DateTime.Now);
            RecreationalTeam team = new RecreationalTeam();
            r.Team = team;
            r.Duration = new TimeSpan(2, 0, 0);

            context.Reservations.Add(r);


            context.Members.AddOrUpdate(new Member()
            {
                Name = "Harm",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                Organisation = "HBO-ICT",
                Email = "test@example",
                Address = new Address()
                {
                    Street = "Sesamstraat",
                    HouseNumber = 37,
                    ZIP = "9999ZZ",
                    City = "Den Haag"
                },
                Password = "7bca025eff4fb877bea86faac56c909b65c97adfba23b7c1fb6b9772d34b420e" //Welkom123
            });

            context.SaveChanges();
        }
    }
}
