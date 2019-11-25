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
        
        public int ID { get; private set; }

        [Required]
        public string Name { get; set; }
        
        public virtual BoatType BoatType { get; set; }


        public List<User> Users { get; set; }

        public Certificate(string name)
        {
            Name = name;
        }

        private Certificate() { }
    }
}
