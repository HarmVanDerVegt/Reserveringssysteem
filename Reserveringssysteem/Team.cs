using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    abstract class Team
    {
        public int ID { get; set; }

        public User Coxswain { get; set; }

        public List<Reservation> Reservations { get; set; }

        public List<User> Users { get; set; }

        public List<Match> Matches { get; set; }
    }
}
