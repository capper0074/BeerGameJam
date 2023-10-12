using GameJam.Stuff;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Character
{
    public static class WeaponSlot
    {
        private static bool isInitialize;

        private static Weapons weapon;

        private static string path;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }


            if (!isInitialize)
            {
                weapon = new Weapons(GameItems.weaponList[1].Name, GameItems.weaponList[1].Weapon_Attack, GameItems.weaponList[1].AssetName);
                isInitialize = true;
            }
            string temp = Path.GetFullPath("SpriteAssets");
            string[] array = temp.Split('\\');
            string stringRemove;


            array = array.Where(val => val != "bin" && val != "Debug" && val != "net6.0" && val != "SpriteAssets").ToArray();


            path = string.Join("\\", array);
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
            Console.WriteLine("Dette er dit våben: " + weapon.Name + ", dit våbens styrke er: " + weapon.Weapon_Attack);

            // Load an image
            var image = new CanvasImage($@"{path}\Graphic\SpriteAssets\{weapon.AssetName}.png");

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
