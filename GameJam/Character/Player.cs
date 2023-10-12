using GameJam.Graphic;
using GameJam.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace GameJam.Character
{
    public static class Player
    {
        public static string Name { get; set; }

        public static int Health { get; set; }

        public static int Stamina { get; set; }

        public static int Drunk { get; set; }

        public static int Piss { get; set; }

        private static bool isInitialize;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }
            else
            {
                Name = "Møller";
                Health = 100;
                Stamina = 100;
                Drunk = 10;
                Piss = 20;

                isInitialize = true;
            }

        }

        public static void Display_Stats()
        {
            Console.Clear();
            Console.WriteLine("Your name are: " + Name);
            Beautifier.CoolBar(Health, Stamina, Drunk, Piss);
        }

        public static void Tick_Stamina()
        {
            Stamina = Stamina - 10;
        }

        public static void Tick_Piss()
        {
            Piss += 1 * (Drunk / 10);
        }

        public static void Tick_PissDamage()
        {
            if(Piss == 100)
            {
                Health -= 12;
            }
        }

        public static void TakeAPiss()
        {
            Piss = 0;
        }

        public static void Eat(Items food)
        {
            Health += food.HealthStat;
            Stamina += food.StaminaStat;
            Drunk += food.DrunkStat;

            Console.Clear();

            Beautifier.CoolWrite("purple", $"Your Health have increased by {food.HealthStat}");
            Beautifier.CoolWrite("purple", $"Your Stamina have increased by {food.StaminaStat}");
            Beautifier.CoolWrite("purple", $"Your Drunk have increased by {food.DrunkStat}");

        }






    }
}
