using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reserveringssysteem
{
    public class Match
    {
        public int ID { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int Distance { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public BoatType Type { get; set; }

        public List<MatchTeam> Participants { get; set; }
        public List<Result> Results { get; set; }

        [NotMapped]
        private static List<int> IDList = new List<int>();

        public static void SetIDList(int id)
        {
            IDList.Add(id);
        }

        public static void RemoveMatch()
        {
            using (var db = new ReserveringssysteemContext())
            {
                foreach (int id in IDList)
                {
                    Match query = (from item in db.Matches where item.ID == id select item).Single();
                    db.Matches.Remove(query);
                }
                db.SaveChanges();
            }
        }
        public static void AddMatch(DateTime date, int distance, TimeSpan duration, BoatType boattype)
        {
            using (var db = new ReserveringssysteemContext())
            {
                BoatType type = (from bt in db.BoatTypes
                                 where bt.ID == boattype.ID
                                 select bt).Single();

                Match match = new Match() { DateTime = date, Distance = distance, Duration = duration, Type = type, /*Participants = teams*/ };
                db.Matches.Add(match);
                db.SaveChanges();
            }
        }
        //Refactor to matchcreatordialog
        public static bool CheckGivenInputValue(List<MatchTeam> teams, BoatType boattype, int starttime, int endtime)
        {
            bool checkteams = teams.Count > 1 ? true : false;
            bool checkboattype = boattype != null ? true : false;
            bool checkstarttime = (starttime > -1) ? true : false;
            bool checkendtime = (endtime > -1) ? true : false;

            if (checkteams && checkboattype && checkstarttime && checkendtime)
            {
                return true;
            }
            return false;


        }
        private static bool TimeIsAvaible(DateTime startTime, List<Match> query, int Margin)
        {
            foreach (var item in query)
            {
                //If the time collides with the time of an existing match, escape with false.
                if (startTime < item.DateTime + item.Duration && startTime.AddMinutes(Margin) > item.DateTime)
                {
                    return false;
                }
            }
            return true;

        }
        //Date of reservation at 00:00, Clockhour-, ClockMinute when reserving is possible, Clockhour-, ClockMinute when reserving is no longer possible. Margin of minimal duration of a match, Stop giving possible timestamps when first planned match has been met. 
        public static List<TimeSpan> GetAvaibleTime(DateTime day, bool stopOnMatchReach, TimeSpan SelectStartTime)
        {
            using (var db = new ReserveringssysteemContext())
            {
                List<TimeSpan> returnList = new List<TimeSpan>();
                DateTime startTime = day.Add(Reservation.ReservationStartTime);
                DateTime endTime = day.Add(Reservation.ReservationEndTime);
                int MarginMinute = Reservation.ReservationLength;

                if (stopOnMatchReach) { startTime = startTime.AddMinutes(MarginMinute).Add(SelectStartTime); Console.WriteLine($"--1-1-{ startTime}"); MarginMinute = 0; }

                var query = from Match in db.Matches
                            select Match;

                Console.WriteLine($"ST{startTime} {endTime}");
                Console.WriteLine(startTime <= endTime);
                while (startTime <= endTime)
                {
                    Console.WriteLine($"ST{startTime} ET {endTime}");
                    if (TimeIsAvaible(startTime, query.ToList(), MarginMinute))
                    {
                         returnList.Add(startTime.TimeOfDay); 
                    }
                    else
                    {
                        if (stopOnMatchReach) { break; } 
                    }
                    startTime += new TimeSpan(0, Reservation.ReservationStep, 0);

                }
                return returnList;
            }
        }
    }
}
