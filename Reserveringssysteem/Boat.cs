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
    public class Boat
    {
        private static int IdCounter = 0;

        public int ID { get; set; }

        [Required, EnumDataType(typeof(BoatStatus))]
        public BoatStatus Status { get; set; }

        [Required]
        public BoatType Type { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
