using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class Reservation
    {
        [NotMapped]
        public static int ReservationStep = 15; // At which interval it's possible to reserve
        [NotMapped]
        public static int ReservationLength = 30; // Minimal reservation duration.
        [NotMapped]
        public static TimeSpan ReservationStartTime = new TimeSpan(12, 0, 0); // Time at which reservations are open
        [NotMapped]
        public static TimeSpan ReservationEndTime = new TimeSpan(17, 0, 0); // Time at which reservations are closed
        public int ID { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public Team Team { get; set; }

        [Required]
        public Boat Boat { get; set; }

        /// <summary>
        /// Reserves a boat for a team.
        /// </summary>
        /// <param name="team">The team for who to reserve a boat.</param>
        /// <param name="boat">The boat to reserve.</param>
        /// <param name="startTime">The time from when you want to reserve the boat.</param>
        /// <param name="duration">The duration of the reservation.</param>
        /// <returns>Returns true if the reservation went successfully into the database.</returns>
        public static bool Reserve(Team team, Boat boat, DateTime startTime, TimeSpan duration)
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                Reservation reservation = new Reservation();
                reservation.Boat = context.Boats.Find(boat.ID);
                reservation.DateTime = startTime;
                reservation.Duration = duration;

                RecreationalTeam recreationalTeam = new RecreationalTeam() { Users = new List<User>() };

                foreach (User user in team.Users)
                    recreationalTeam.Users.Add(context.Users.Find(user.ID));

                reservation.Team = recreationalTeam;

                context.Reservations.Add(reservation);

                try { context.SaveChanges(); }
                catch (Exception) { return false; }
            }

            return true;
        }

        /// <summary>
        /// Gets all available start times and a boat for a reservation.
        /// </summary>
        /// <param name="boatType">The type of boat you want an available boat from.</param>
        /// <param name="date">The date on which you want to make a reservation.</param>
        /// <param name="duration">The duration of the reservation.</param>
        /// <param name="availableBoat">Gives an available boat, if none is available it will give null.</param>
        /// <returns>All available start times</returns>
        public static DateTime[] GetAvailableBoatStartTimes(BoatType boatType, DateTime date, TimeSpan duration, out Boat availableBoat)
        {
            List<DateTime> startTimes = new List<DateTime>();

            // Reset time to 00:00:00
            date = date.Date + new TimeSpan(0, 0, 0);

            availableBoat = null;

            // Check if this boat type contains any boats.
            if (boatType != null && boatType.Boats != null && boatType.Boats.Count > 0)
                // Loop each 15 minutes from 12:00 to 17:00.
                for (DateTime startTime = date.AddHours(12); startTime <= date.AddHours(17); startTime += new TimeSpan(0, 15, 0))
                {
                    DateTime endTime = startTime + duration;
                    bool atLeastOneBoatAvailable = false;

                    // Check if it is lower than 17:00.
                    if (endTime <= date.AddHours(17))
                        foreach (Boat boat in boatType.Boats)
                        {
                            // Check if this boat is still intact and if we didn't find a boat already.
                            if (boat.BoatStatus == BoatStatus.Whole && !atLeastOneBoatAvailable)
                            {
                                bool noOverlap = true;

                                foreach (Reservation reservation in boat.Reservations)
                                {
                                    // Check if there is an overlap with the current start time and the current reservation.
                                    if (startTime <= reservation.DateTime + reservation.Duration && reservation.DateTime <= endTime)
                                    {
                                        noOverlap = false;
                                        break;
                                    }
                                }

                                // The current boat is available when there was no overlap.
                                if (noOverlap)
                                {
                                    if (availableBoat == null)
                                        availableBoat = boat;

                                    atLeastOneBoatAvailable = true;
                                    break;
                                }
                            }
                        }

                    // Add this start time to all available start times.
                    if (atLeastOneBoatAvailable)
                        startTimes.Add(startTime);
                }

            return startTimes.ToArray();
        }

        public Reservation(Boat b, DateTime d)
        {
            DateTime = d;
            Boat = b;
        }
        public Reservation() { }
    }
}
