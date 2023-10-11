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
                isInitialize = true;
            }

        }






    }
}
