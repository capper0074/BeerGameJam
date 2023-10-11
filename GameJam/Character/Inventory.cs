using GameJam.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Character
{
    internal static class Inventory
    {
        private static List<Items> inventory; //List containing the type Items

        private static bool isInitialize;
        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }

            inventory = new List<Items>();

            if (inventory.Count == 0)
            {
                Items cookie = new Items("Cookie", 10);
                Items apple = new Items("Apple", 5);
                Items mushroom = new Items("Mushroom", 10);
                inventory.Add(cookie);
                inventory.Add(apple);
                inventory.Add(mushroom);

                Items empty_slot = new Items("Empty_Slot", 0);

                for (int i = 0; i < 10 - inventory.Count; i++)
                {
                    inventory.Add(empty_slot);
                }

                isInitialize = true;
            }

        }

        public static void DisplayInventory()
        {
            throw new NotImplementedException(); //TODO: Implement to display inventory
        }

        public static void AddToInventory(Items item)
        {
            throw new NotImplementedException(); //TODO: Implement this to add an item to inventory
        }

        public static void PickFromInventory(Items item)
        {
            throw new NotImplementedException(); //TODO: Implement this to pick an item from inventory
        }
    }
}
