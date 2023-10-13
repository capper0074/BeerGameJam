using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Fighting
{
    public static class Enemy
    {

        private static bool IsInitialized;

        private static List<Creatures> enemies;


        public static void Initialize()
        {
            if (IsInitialized)
            { 
                return; 
            }

            enemies = new List<Creatures>();

            if (!IsInitialized)
            {
                IsInitialized = true;

                Creatures jan = new Creatures("J'Bro", 5, 100);

                Creatures leif = new Creatures("Leif", 5, 100);

                Creatures rengøringsDame = new Creatures("Rengørings Dame", 5, 100);

                enemies.Add(leif);
                enemies.Add(jan);
                enemies.Add(rengøringsDame);
            }

        }

        public static Creatures Rengøring()
        {
            return enemies[2];
        }

        public static Creatures Enemy_Pick()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, enemies.Count);
            return enemies[num];
        }
    }
}
