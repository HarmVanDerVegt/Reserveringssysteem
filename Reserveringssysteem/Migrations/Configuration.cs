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

            context.Matches.RemoveRange(context.Matches.Include(m => m.Participants));
            context.BoatTypes.RemoveRange(context.BoatTypes.Include(bt => bt.Matches)
                                                           .Include(bt => bt.Certificate));
            context.Certificates.RemoveRange(context.Certificates);


            context.BoatTypes.AddOrUpdate(new BoatType("Skiff", 1, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Dubbel Twee", 2, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Twee Zonder", 2, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Twee Met", 2, true));
            context.BoatTypes.AddOrUpdate(new BoatType("Dubbel Vier", 4, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Dubbel Vier Met", 4, true));
            context.BoatTypes.AddOrUpdate(new BoatType("Vier Zonder", 4, false));
            context.BoatTypes.AddOrUpdate(new BoatType("Vier Met", 4, true));
            context.BoatTypes.AddOrUpdate(new BoatType("Acht", 8, true));

            context.Users.AddOrUpdate(new User()
            {
                Name = "Harm",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                Organisation = "HBO-ICT"
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

            context.Teams.AddOrUpdate(new MatchTeam()
            {
                Name = "FaZe clan"
            });

            context.SaveChanges();
        }
    }
}
