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
            //context.Users.Add(new Member() { DateOfBirth = DateTime.Now, 
            //    Gender = Gender.Male, 
            //    Name = "Kappa", 
            //    Organisation = "Bier", 
            //    Address = new Address() { City = "Zwolle", HouseNumber = 16, Street = "Roeistraat", ZIP = "7741 AB" }, 
            //    Email = "a@a", 
            //    Password = "asdf"});
            context.SaveChanges();
        }
    }
}
