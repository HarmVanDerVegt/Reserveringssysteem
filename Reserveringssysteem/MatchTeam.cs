using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class MatchTeam : Team
    {
        [Required]
        public string Name { get; set; }
    }
}
