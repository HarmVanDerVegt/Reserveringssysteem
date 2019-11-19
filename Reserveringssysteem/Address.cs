using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reserveringssysteem
{
    public class Address
    {
        [Key, ForeignKey("Member")]
        public int ID { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public int HouseNumber { get; set; }

        public string Suffix { get; set; }

        [Required]
        public string ZIP { get; set; }

        [Required]
        public string City { get; set; }

        public Member Member { get; set; }

    }
}
