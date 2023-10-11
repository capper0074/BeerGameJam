using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Fighting
{
    public class Enemy
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public static bool IsInitialized { get; set; }

        private static List<Enemy> Enemies = new();

        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public static void Initialize()
        {
            if (IsInitialized) return;

            if (!IsInitialized)
            {
                IsInitialized = true;

                Enemy jan = new Enemy("J'Bro", 100);

                Enemy leif = new Enemy("Leif", 100);

                Enemies.Add(leif);
                Enemies.Add(jan);
            }
        }

        public static void DisplayEnemy(Enemy enemy)
        {
            throw new NotImplementedException(); //TODO: Implement this method to display this enemy
        }

        public static void AttackEnemy(Enemy enemy)
        {
            throw new NotImplementedException(); //TODO: Implement this method to deal damage to an enemy
        }
    }
}
