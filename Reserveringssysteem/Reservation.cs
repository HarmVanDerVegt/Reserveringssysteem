using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem
{
    class Reservation
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
