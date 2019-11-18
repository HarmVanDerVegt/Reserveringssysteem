using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public enum BoatStatus { Whole, Maintenance, Broken };
    class Boat
    {
        public int ID { get; set; }

        [Required]
        public BoatStatus Status { get; set; }

        [Required]
        public BoatType Type { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
