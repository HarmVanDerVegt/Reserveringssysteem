using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem
{
    public enum Gender { Male, Female };
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Organisation { get; set; }

        public List<Certificate> Levels = new List<Certificate>();

    }
}
