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
            Beautifier.CoolWrite("white", $"Narrator: ");
            //Beautifier.CoolWrite("green", $"{Player.name} 
        }

        public static void VendorPerson()
        {

        }

        //metode.. 
        //vendor intro (kan både være butik eller person, to void metoder
        //
        //snakker med vendor
        //ja nej
        //hvis ja 
        //hvis nej
    }
}
