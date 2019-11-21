using System.Data.Entity;

namespace Reserveringssysteem
{
    public class ReserveringssysteemContext : DbContext
    {
        public DbSet<Boat> Boats { get; set; }
        public DbSet<BoatType> BoatTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<RecreationalTeam> RecreationalTeams { get; set; }
        public DbSet<MatchTeam> MatchTeams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Member> Members { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
