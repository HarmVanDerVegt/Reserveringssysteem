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
            context.Members.RemoveRange(context.Members.Include(m => m.Address));
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

            context.Users.AddOrUpdate(new Member()
            {
                Name = "Beau ter Ham",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                Organisation = "Roeivereniging",
                Address = new Address() { City = "Zwolle", HouseNumber = 42, Street = "Roeistraat", ZIP = "1234 AB" },
                Email = "beauterham@gmail.com",
                Password = "#",
            }, new Member()
            {
                Name = "Harry Snotter",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                Organisation = "Roeivereniging",
                Address = new Address() { City = "Zwolle", HouseNumber = 42, Street = "Roeistraat", ZIP = "1234 AB" },
                Email = "harrysnotter@gmail.com",
                Password = "#",
            }, new Member()
            {
                Name = "Pieter Post",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                Organisation = "Roeivereniging",
                Address = new Address() { City = "Zwolle", HouseNumber = 42, Street = "Roeistraat", ZIP = "1234 AB" },
                Email = "pieterpost@gmail.com",
                Password = "#",
            }, new Member()
            {
                Name = "Prog Ramma",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                Organisation = "Roeivereniging",
                Address = new Address() { City = "Zwolle", HouseNumber = 42, Street = "Roeistraat", ZIP = "1234 AB" },
                Email = "programma@gmail.com",
                Password = "#",
            });

            context.SaveChanges();

            System.Collections.Generic.List<Certificate> certificates = new System.Collections.Generic.List<Certificate>();
            certificates.Add(context.Certificates.Where(c => c.Name == "Certificate Skiff").First());
            context.Users.Where(u => u.Name == "Prog Ramma").First().Levels = certificates;
            context.SaveChanges();
        }
    }
}
