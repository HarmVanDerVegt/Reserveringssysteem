using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveringssysteem
{
    public class BoatType
    {
        private static int IdCounter = 0;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public bool HasCoxswain { get; set; }
        public static List<BoatType> Fleet = new List<BoatType>();//LATER VERWIJDEREN

        public BoatType(string name, int size, bool hasCoxswain)
        {
            ID = IdCounter;
            Name = name;
            Size = size;
            HasCoxswain = hasCoxswain;
            IdCounter++;
        }

        public static void CreateBoatTypes()
        {
            BoatType Skiff = new BoatType("Skiff", 1, false);
            BoatType DubbelTwee = new BoatType("Dubbel Twee", 2, false);
            BoatType TweeZonder = new BoatType("Twee Zonder", 2, false);
            BoatType TweeMet = new BoatType("Twee Met", 2, true);
            BoatType DubbelVier = new BoatType("Dubbel Vier", 4, false);
            BoatType DubbelVierMet = new BoatType("Dubbel Vier Met", 4, true);
            BoatType VierZonder = new BoatType("Vier Zonder", 4, false);
            BoatType VierMet = new BoatType("Vier Met", 4, true);
            BoatType Acht = new BoatType("Acht", 8, true);
            Fleet.Add(Skiff);
            Fleet.Add(DubbelTwee);
            Fleet.Add(TweeZonder);
            Fleet.Add(TweeMet);
            Fleet.Add(DubbelVier);
            Fleet.Add(DubbelVierMet);
            Fleet.Add(VierZonder);
            Fleet.Add(VierMet);
            Fleet.Add(Acht);
        }
    }
}
