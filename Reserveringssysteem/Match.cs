using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem
{
    class Match
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
        public List<MatchTeam> Participants = new List<MatchTeam>();
    }
}
