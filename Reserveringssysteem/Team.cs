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
        /// Get all available boat types based on the team's certificates and size.
        /// </summary>
        /// <returns>An array of boat types.</returns>
        public BoatType[] GetAvailableBoatTypes()
        {
            List<BoatType> boatTypes = new List<BoatType>();

            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
                foreach (BoatType boatType in context.BoatTypes.Include("Certificate").Include("Boats.Reservations"))
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

        /// <summary>
        /// Get all available coxswains in this team.
        /// </summary>
        /// <returns>An array of users who are able to be a coxswain.</returns>
        public User[] GetAvailableCoxswains()
        {
            List<User> coxswains = new List<User>();

            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                // Get the coxswain certificate
                Certificate coxswainCertificate = context.Certificates.Where(c => c.Name.Equals("Certificate Stuurman")).FirstOrDefault();

                foreach (User user in Users)
                    // Check if this user contains the coxswain certificate.
                    if (user.Levels != null && coxswainCertificate != null && user.Levels.Select(c => c.ID).ToList().Contains(coxswainCertificate.ID))
                        coxswains.Add(user);
            }

            return coxswains.ToArray();
        }
    }
}
