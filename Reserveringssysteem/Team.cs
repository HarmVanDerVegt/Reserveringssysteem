using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public abstract class Team
    {
        public int ID { get; set; }

        public User Coxswain { get; set; }

        public List<Reservation> Reservations { get; set; }

        public List<User> Users { get; set; }

        public List<Match> Matches { get; set; }

        /// <summary>
        /// Get all available boat types based on a given team's certificates and size.
        /// </summary>
        /// <returns>An array of boat types</returns>
        public BoatType[] GetAvailableBoatTypes()
        {
            List<BoatType> boatTypes = new List<BoatType>();

            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
                foreach (BoatType boatType in context.BoatTypes.Include("Certificate"))
                    // Check if this boat type has the same size as the team.
                    if (boatType.Size + (boatType.HasCoxswain ? 1 : 0) == Users.Count)
                    {
                        bool available = true;

                        foreach (User user in Users)
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
