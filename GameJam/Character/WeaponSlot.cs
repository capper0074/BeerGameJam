using GameJam.Stuff;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Character
{
    public static class WeaponSlot
    {
        private static bool isInitialize;

        private static Weapons weapon;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }


            if (!isInitialize)
            {
                Weapons hands = new Weapons("Hands", 5, "Sword.PNG");
                weapon = new Weapons(hands.Name, hands.Weapon_Attack, hands.AssetName);
                isInitialize = true;
            }
        }

        public static void SwitchWeapon(Weapons newWeapon)
        {

            bool state = true;

            while (state == true)
            {
                Console.Clear();
                Console.WriteLine("Congrats you just found a new weapon");
                Console.WriteLine("you found: " + newWeapon.Name + " And it's stats are: " + newWeapon.Weapon_Attack);
                Console.WriteLine("your current weapon is: " + weapon.Name + " And it's stats are: " + weapon.Weapon_Attack);
                Console.WriteLine("Do you want to switch Yes / No");
                string playerChoice = Console.ReadLine();

                if (playerChoice.ToLower() == "yes")
                {
                    weapon = newWeapon;
                    Console.WriteLine("You just switched your weapon :)");
                    //Kommer ikke videre når man skriver Ja. Opdatere kun stats og derefter skal man skrive no for at hoppe videre 

                }
                else if (playerChoice.ToLower() == "no")
                {
                    state = false;
                    Console.Clear();
                }

            }

        }

        public static void DisplayCurrentWeapon()
        {
            Console.WriteLine("This is your current weapon: " + weapon.Name + " And it's stats are: " + weapon.Weapon_Attack);

            // Load an image
            var image = new CanvasImage(@"C:\Users\emilm\Desktop\Programmering\Datamatiker - RP\BeerGameJam\GameJam\Graphic\SpriteAssets\" + weapon.AssetName);

            // Set the max width of the image.
            // If no max width is set, the image will take
            // up as much space as there is available.
            image.MaxWidth(16);

            // Render the image to the console
            AnsiConsole.Write(image);
        }

        public static string DisplayName()
        {
            return weapon.Name;
        }

        public static int DisplayStat()
        {
            return weapon.Weapon_Attack;
        }
    }
}
