using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class Result
    {
        public int ID { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        [Required]
        public int Position { get; set; }
        
        [Required]
        public Match Match { get; set; }
    }
}
