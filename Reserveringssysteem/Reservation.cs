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
        public int ID { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public Team Team { get; set; }

        [Required]
        public Boat Boat { get; set; }

        public DateTime[] GetAvailableStartTimes(BoatType boatType, DateTime date, TimeSpan duration)
        {
            List<DateTime> startTimes = new List<DateTime>();

            date = date.Date + new TimeSpan(0, 0, 0);

            if (boatType.Boats.Count > 0)
                // Start enumerating from 12:00 to 17:00 (each 15 minutes)
                for (DateTime startTime = date.AddHours(12); startTime <= date.AddHours(17); startTime += new TimeSpan(0, 15, 0))
                {
                    bool available = false;
                    DateTime endTime = startTime + duration;

                    foreach (Boat boat in boatType.Boats)
                    {
                        if (available) break;

                        foreach (Reservation reservation in boat.Reservations)
                        {
                            if (!(startTime <= reservation.DateTime + reservation.Duration && reservation.DateTime <= endTime))
                            {
                                available = true;
                                break;
                            }
                        }
                    }

                    if (available) startTimes.Add(startTime);
                }

            return startTimes.ToArray();
        }
    }
}
