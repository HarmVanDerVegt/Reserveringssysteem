namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Collections.Generic;
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

            context.Users.AddOrUpdate(new User()
            {
                Name = "Harm",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                Organisation = "HBO-ICT"
            });

            context.Members.Add(new Member()
            {
                Name = "Victor",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                Organisation = "Roeivereniging",
                Address = new Address() { City = "Zwolle", HouseNumber = 42, Street = "Roeistraat", ZIP = "1234 AB" },
                Email = "vhemmekam@gmail.com",
                Password = "bier123",
            });

            context.SaveChanges();

            List<Certificate> certificates = new List<Certificate>();
            certificates.Add(context.Certificates.Where(c => c.Name == "Certificate Skiff").First());
            context.Members.Where(u => u.Name == "Victor").First().Levels = certificates;

            context.SaveChanges();
        }
    }
}
