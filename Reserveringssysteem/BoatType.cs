using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class BoatType
    {
        [ForeignKey("Certificate")]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public bool HasCoxswain { get; set; }

        [Required]
        public virtual Certificate Certificate { get; set; }

        public List<Match> Matches { get; set; }
        public List<Boat> Boats { get; set; }

        public BoatType(string name, int size, bool hasCoxswain)
        {
            Name = name;
            Size = size;
            HasCoxswain = hasCoxswain;
            Certificate temp = new Certificate($"Certificate {name}");
            temp.BoatType = this;

            using (var db = new ReserveringssysteemContext())
            {
                db.Certificates.Add(temp);
                //db.SaveChanges();
            }

            Certificate = temp;
        }

        private BoatType() { }

        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Get all available boat types based on a given team's certificates and size.
        /// </summary>
        /// <param name="team">The team from which the certificates and the size will be obtained.</param>
        /// <returns>An array of boat types</returns>
        public static BoatType[] GetAvailableBoatTypes(Team team)
        {
            List<BoatType> boatTypes = new List<BoatType>();

            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
                foreach (BoatType boatType in context.BoatTypes.Include("Certificate"))
                    // Check if this boat type has the same size as the team.
                    if (boatType.Size + (boatType.HasCoxswain ? 1 : 0) == team.Users.Count)
                    {
                        bool available = true;

                        foreach (User user in team.Users)
                            // Check if this user contains the certificate of this boat type, if not then this boat is not available.
                            if (user.Levels == null || !user.Levels.Select(c => c.ID).ToList().Contains(boatType.Certificate.ID))
                            {
                                available = false;
                                break;
                            }

                        if (available)
                            boatTypes.Add(boatType);
                    }

            return boatTypes.ToArray();
        }
    }
}
