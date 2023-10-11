﻿using GameJam.Graphic;
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

        public static int health { get; set; }

        public static int stamina { get; set; }

        public static int drunk { get; set; }

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
                health = 100;
                stamina = 100;
                drunk = 100;
                isInitialize = true;
            }

        }

        public static void Display_Stats()
        {
            Console.Clear();
            Console.WriteLine("Your name are: " + Name);
            Beautifier.CoolBar(health, stamina, drunk);
        }

        public static void Tick_Stamina()
        {
            stamina = stamina - 10;
        }

        //public static void Eat(Items food)
        //{
        //    return null;
        //}






    }
}
