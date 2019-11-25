﻿using System;
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

        public static DateTime[] GetAvailableStartTimes(BoatType boatType, DateTime date, TimeSpan duration)
        {
            List<DateTime> startTimes = new List<DateTime>();

            date = date.Date + new TimeSpan(0, 0, 0);

            if (boatType != null && boatType.Boats != null && boatType.Boats.Count > 0)
                for (DateTime startTime = date.AddHours(12); startTime <= date.AddHours(17); startTime += new TimeSpan(0, 15, 0))
                {
                    DateTime endTime = startTime + duration;
                    bool available = false;

                    foreach (Boat boat in boatType.Boats)
                    {
                        if (available) break;

                        if (boat.BoatStatus == BoatStatus.Whole)
                        {
                            if (boat.Reservations.Count == 0)
                            {
                                available = true;
                                break;
                            }

                            foreach (Reservation reservation in boat.Reservations)
                            {
                                if (!(startTime <= reservation.DateTime + reservation.Duration && reservation.DateTime <= endTime))
                                {
                                    available = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (available) startTimes.Add(startTime);
                }

            return startTimes.ToArray();
        }
    }
}
