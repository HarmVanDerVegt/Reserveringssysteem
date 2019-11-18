using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Reserveringssysteem
{
    class ReserveringssysteemContext : DbContext
    {
       DbSet<Boat> Boats { get; set; }
    }
}
