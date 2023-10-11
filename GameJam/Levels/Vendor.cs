using GameJam.Character;
using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Levels
{
    public static class Vendor
    {
        public static void VendorIntro(string vendor)
        {
            if (vendor.ToLower() == "person")
            {
                VendorPerson();
            }
            else if (vendor.ToLower() == "shop")
            {
                VendorShop();
            }
        }

        public static void VendorShop()
        {
            Beautifier.CoolWrite("green", "Narrator: ");
            Beautifier.CoolWrite("white", $"{Player.Name} ser lidl");

            string playerChoice = Beautifier.CoolMenu("Vil du købe noget?", "Ja", "Nej");

            if (playerChoice == "Ja")
            {
                throw new NotImplementedException();
            }
            else if (playerChoice == "Nej")
            {
                Console.WriteLine("Tak for besøget");
            }
        }

        public static void VendorPerson()
        {
            Beautifier.CoolWrite("green", "Narrator: ");
            Beautifier.CoolWrite("white", $"{Player.Name} ser en vendor");

            string playerChoice = Beautifier.CoolMenu("Vil du købe noget?", "Ja", "Nej");

            if (playerChoice == "Ja")
            {
                throw new NotImplementedException();
            }
            else if (playerChoice == "Nej")
            {
                Console.WriteLine("Tak for besøget");
            }
        }
    }
}
