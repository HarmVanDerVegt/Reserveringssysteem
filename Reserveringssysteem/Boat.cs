using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem
{
    public enum BoatStatus { Whole, Maintanance, Broken };
    public class Boat
    {
        private static int IdCounter = 0;

        public int ID { get; set; }
        public BoatStatus Status = BoatStatus.Whole;
        public BoatType BoatType;        

        public Boat(BoatType boatType)
        {
            ID = IdCounter;
            BoatType = boatType;
            IdCounter++;
        }
    }
}
