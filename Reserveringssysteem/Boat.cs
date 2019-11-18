using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem
{
    public enum BoatStatus { Whole, Maintenance, Broken };
    class Boat
    {
        public int ID { get; set; }
        public BoatStatus Status { get; set; }
        public BoatType Type { get; set; }
    }
}
