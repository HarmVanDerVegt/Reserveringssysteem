using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class Certificate
    {
        [ForeignKey("Type")]
        public int ID { get; private set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public BoatType Type { get; set; }

        public List<User> Users { get; set; }
    }
}
