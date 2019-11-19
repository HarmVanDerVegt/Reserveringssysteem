using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace Reserveringssysteem
{
    public class Member : User
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public Address Address { get; set; }

        public List<Role> Roles { get; set; }

        [NotMapped]
        public static Member CurrentMember { get; set; }

        public static void Login(string Email, string Password)
        {
            string HashedPassword;


            using (var db = new ReserveringssysteemContext())
            {
                using (SHA256 SHA = SHA256.Create())
                {
                    HashedPassword = Encoding.ASCII.GetString(
                        SHA.ComputeHash(Encoding.ASCII.GetBytes(Password)));

                    CurrentMember = (from user in db.Users
                                     where Password == HashedPassword
                                     select user).First() as Member;
                }
            }
        }

    }
}
