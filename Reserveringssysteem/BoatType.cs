using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class BoatType
    {
        private static int IdCounter = 0;

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public bool HasCoxswain { get; set; }

        [Required]
        public Certificate Certificate { get; set; }

        public List<Match> Matches { get; set; }
        public List<Boat> Boats { get; set; }

    }
}
