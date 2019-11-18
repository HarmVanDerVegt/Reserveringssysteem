using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem
{
    abstract class Team
    {
        public int ID { get; set; }
        public bool HasCoxswain { get; set; }
        public List<Reservation> Reservations = new List<Reservation>(); 
    }
}
