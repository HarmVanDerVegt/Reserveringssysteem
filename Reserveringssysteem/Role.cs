using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace Reserveringssysteem
{
    public enum RoleType
    {
        Admin,
        TournamentOrganiser,
        ChiefOfEquipment
    }

    public class Role
    {
        public int ID { get; set; }

        [Required, EnumDataType(typeof(RoleType)), Index(IsUnique = true)]
        public RoleType Type { get; set; }

        public virtual List<Member> Members { get; set; }

        public static Role GetRole(RoleType role)
        {
            Role toReturn;

            using (var db = new ReserveringssysteemContext())
            {
                toReturn = db.Roles.Include(r => r.Members).Where(r => r.Type == role).Single();
            }


            return toReturn;
        }

        public Role(RoleType type)
        {
            Type = type;
        }

        public Role()
        {

        }
    }
}
