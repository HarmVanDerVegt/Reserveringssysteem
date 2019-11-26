using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.Entity;


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

        public virtual List<Role> Roles { get; set; }

        public bool HasRole(RoleType roleType)
        {

            using (var db = new ReserveringssysteemContext())
            {
                Role role = Role.GetRole(roleType);

                var member = (from m in db.Members.Include(m => m.Roles)
                              where m.ID == this.ID
                              select m).Single();

                var roleToQuery = (from r in db.Roles.Include(r => r.Members)
                                   where r.ID == role.ID
                                   select r).Single();

                return member.Roles.Contains(roleToQuery);
            }
        }

        public void AddRole(RoleType roleType)
        {
            if (!HasRole(roleType))
            {
                using (var db = new ReserveringssysteemContext())
                {
                    Role role = Role.GetRole(roleType);

                    var member = (from m in db.Members.Include(m => m.Roles)
                                  where m.ID == this.ID
                                  select m).Single();

                    var roleToAdd = (from r in db.Roles.Include(ro => ro.Members)
                                     where r.ID == role.ID
                                     select r).Single();

                    member.Roles.Add(roleToAdd);

                    db.SaveChanges();
                }
            }
        }

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

        public static bool Register(string name, DateTime dateOfBirth, Gender gender,
                                    string organisation, string email, string password,
                                    Address address)
        {
            if (String.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("Email must not be null.");
            }

            if (String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Password must not be null.");
            }

            if (address == null)
            {
                throw new ArgumentNullException("Address must not be null.");
            }

            if (password.Length < 6)
            {
                throw new ArgumentException("Password is too short.");
            }

            if (password.Length > 99)
            {
                throw new ArgumentException("Password is too long.");
            }

            string HashedPassword;

            using (var db = new ReserveringssysteemContext())
            {

                if (db.Members.Where(m => m.Email == email).SingleOrDefault() != null)
                {
                    return false; ;
                }

                using (SHA256 SHA = SHA256.Create())
                {
                    StringBuilder stringBuilder = new StringBuilder();

                    foreach (byte b in SHA.ComputeHash(Encoding.UTF8.GetBytes(password))){
                        stringBuilder.Append(b.ToString("x2"));
                    }

                    HashedPassword = stringBuilder.ToString();

                    Member member = new Member()
                    {
                        Name = name,
                        DateOfBirth = dateOfBirth,
                        Gender = gender,
                        Organisation = organisation,
                        Email = email,
                        Password = HashedPassword,
                        Address = address
                    };

                    db.Members.Add(member);

                    db.SaveChanges();

                    return true;
                }
            }
        }

    }
}
