using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reserveringssysteem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem.Tests
{
    [TestClass()]
    public class ReservationTests
    {
        [TestInitialize]
        public void Initialize()
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                context.Boats.Add(new Boat(context.BoatTypes.Where(b => b.Name.Equals("Skiff")).First()));
                context.SaveChanges();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                BoatType boatType = context.BoatTypes.Where(b => b.Name.Equals("Skiff")).First();
                context.Boats.Remove(context.Boats.Include("BoatType").Where(b => b.BoatType.ID == boatType.ID).First());
                context.SaveChanges();
            }
        }

        [TestMethod()]
        public void GetAvailableBoatStartTimesTest_Duration_4_Hours_45_Minutes()
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                BoatType boatType = context.BoatTypes.Include("Boats.Reservations").Where(b => b.Name.Equals("Skiff")).First();
                DateTime[] actual = Reservation.GetAvailableBoatStartTimes(boatType, DateTime.Now, new TimeSpan(4, 45, 0), out Boat boat);
                DateTime date = DateTime.Now.Date + new TimeSpan(0, 0, 0);
                DateTime[] expected = { date.AddHours(12), date.AddHours(12).AddMinutes(15) };
                CollectionAssert.AreEqual(expected, actual);
            }
        }
    }
}