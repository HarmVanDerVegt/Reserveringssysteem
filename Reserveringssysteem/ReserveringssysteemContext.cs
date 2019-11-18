using System.Data.Entity;

namespace Reserveringssysteem
{
    class ReserveringssysteemContext : DbContext
    {
        DbSet<Boat> Boats { get; set; }
        DbSet<BoatType> BoatTypes { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<Match> Matches { get; set; }
        DbSet<Certificate> Certificates { get; set; }
        DbSet<User> Users { get; set; }
        //DbSet<Member> Members { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Result> Results { get; set; }



    }
}
