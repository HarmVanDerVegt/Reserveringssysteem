using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class Role
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Member> Members { get; set; }
    }
}
