using System;
using System.Linq;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reserveringssysteem;

namespace ReserveringssysteemTest
{
    [TestClass]
    public class RegisterTest
    {

        Address address = new Address()
        {
            Street = "Boomkensdiep",
            HouseNumber = 32,
            ZIP = "8032XX",
            City = "Zwolle"
        };

        [TestMethod]
        public void RegisterMemberTest()
        {
            using (var db = new ReserveringssysteemContext())
            {
                bool result = Member.Register("Harm", DateTime.Now, Gender.Male,
                                               "Roeivereniging", "harmvegt@gmail.com", "Wachtwoord",
                                               address);
                Assert.IsTrue(result);
                Assert.AreEqual(1, db.Members
                    .Where(m => m.Email == "harmvegt@gmail.com")
                    .Count());
            }
        }


        public void RegisterHashedPasswordTest()
        {
            using (var db = new ReserveringssysteemContext())
            {
                bool result = Member.Register("Harm", DateTime.Now, Gender.Male,
                                               "Roeivereniging", "harmvegt@gmail.com", "Wachtwoord",
                                               address);
                Assert.IsTrue(result);
                Assert.AreEqual("9a2bca3b828e24f91baa5dd22a49919c14d60efa1375cbdf28ac7b6ff585c2b8",
                    db.Members.ToList().Last().Password);
            }
        }

        [TestMethod]
        public void RegisterMemberWithoutAddressTest()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => Member.Register("Harm", DateTime.Now, Gender.Male,
                                               "Roeivereniging", "harmvegt@gmail.com", "Wachtwoord",
                                               null));
        }

        [TestMethod]
        public void RegisterMemberWithoutPasswordTest()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => Member.Register("Harm", DateTime.Now, Gender.Male,
                                               "Roeivereniging", "harmvegt@gmail.com", null,
                                               address));
        }

        [TestMethod]
        public void RegisterMemberWithoutEmailTest()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => Member.Register("Harm", DateTime.Now, Gender.Male,
                                               "Roeivereniging", null, "Wachtwoord",
                                               address));
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (var db = new ReserveringssysteemContext())
            {
                var member = db.Members
                    .Include(m => m.Address)
                    .Where(m => m.Email == "harmvegt@gmail.com")
                    .SingleOrDefault();

                if (member != null)
                {
                    db.Members.Remove(member);
                    db.SaveChanges();
                }


            }
        }
    }
}
