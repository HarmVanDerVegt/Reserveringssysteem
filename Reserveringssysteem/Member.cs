using System;
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
        public static Member CurrentMember { get; private set; }

        public static bool Login(string email, string password)
        {
            CurrentMember = null;

            if (email == null)
            {
                throw new ArgumentNullException("Email must not be null");
            }

            if (password == null)
            {
                throw new ArgumentNullException("Password must not be null");
            }


            string HashedPassword;

            using (var db = new ReserveringssysteemContext())
            {
                using (SHA256 SHA = SHA256.Create())
                {
                    StringBuilder stringBuilder = new StringBuilder();

                    //We turn our given password into its hashed form
                    //which we'll compare with the stored password in the database
                    foreach (byte b in SHA.ComputeHash(Encoding.UTF8.GetBytes(password)))
                    {
                        stringBuilder.Append(b.ToString("x2"));
                    }

                    HashedPassword = stringBuilder.ToString();

                    var query = from member in db.Members
                                where member.Email == email
                                && member.Password == HashedPassword
                                select member;

                    //We've found a user with this login and password
                    if (query.FirstOrDefault() != null)
                    {
                        CurrentMember = query.First();
                        return true;
                    }

                    //Our list is empty, there are no users with this email and password
                    return false;

                }
            }
        }

        public static void Logout()
        {
            CurrentMember = null;
        }

    }
}
