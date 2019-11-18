using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem
{
    class Adress
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Suffix { get; set; }
        public string ZIP { get; set; }
        public string City { get; set; }

    }
}
