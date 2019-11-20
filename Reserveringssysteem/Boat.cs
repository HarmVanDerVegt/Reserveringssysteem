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
        public int ID { get; set; }

        [Required, EnumDataType(typeof(BoatStatus))]
        public BoatStatus BoatStatus { get; set; }

        [Required]
        public virtual BoatType BoatType { get; set; }

        public List<Reservation> Reservations { get; set; }

        public Boat(BoatType boatType)
        {
            BoatStatus = BoatStatus.Whole;
            BoatType = boatType;

            using (var db = new ReserveringssysteemContext())
            {
                db.Boats.Add(this);
                //db.SaveChanges();
            }

        }

        private Boat() { }
    }
}
