using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class Match
    {
        public int ID { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int Distance { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public BoatType Type { get; set; }

        public List<MatchTeam> Participants { get; set; }
        public List<Result> Results { get; set; }


    }
}
