using GameJam.Graphic;
using GameJam.Stuff;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Character
{
    internal static class Inventory
    {
        public static List<Items> inventory { get; private set; } //List containing the type Items
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
                foreach (var item in GameItems.gameItemList)
                {
                    if (item.IsStartingItem)
                    {
                        inventory.Add(item);
                    }
                }

                Items empty_slot = new Items("Empty_Slot", 0, 0, 0, true);

                for (int i = 0; i < 3; i++) //If you use inventory for this, the for loop is going to check the inventory count every iteration which is not what we want since the inventory count changes every time
                {                           //There are 2 starting items so it adds 3 empty slots making the inventory a 5 slot size, this has to manually changed every time it has to be changed to fit more items
                    inventory.Add(empty_slot);
                }

                isInitialize = true;

            }

        }

        public static void DisplayInventory()
        {
            Console.WriteLine("This is your inventory");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory[i].Name + " || " + inventory[i].HealthStat + " || " + inventory[i].StaminaStat + " || " + inventory[i].DrunkStat);
            }

            bool inv_State = true;

            while (inv_State == true)
            {
                //Made a new menu system, so we can iteract with it.
                var player_Answer = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Do you want to use anything from your inventory\n ---------------------------")
                    .PageSize(3)
                    .AddChoices("yes", "no"));

                if (player_Answer == "yes")
                {

                    var inv_index = AnsiConsole.Prompt(new SelectionPrompt<string>()
                        .Title("Choose what u want from your inventory \n ---------------------------")
                        .PageSize(5)
                        .AddChoices(inventory[0].Name, inventory[1].Name, inventory[2].Name, inventory[3].Name, inventory[4].Name, inventory[4].Name)); //This has to be manually changed to fit the amount of inventory items there are otherwise it will throw an index error
                    //Have removed the player_State while loop because it was an endless loop if the index was empty
                    if (inv_index == "Empty_Slot")
                    {
                        Console.Clear();
                        Beautifier.CoolWrite("red", "U dont have anything in that slot");
                    }
                    else if (inv_index != "Empty_Slot")
                    {
                        int index = inventory.FindIndex(item => item.Name == inv_index);
                        PickFromInventory(inventory[index]);

                        Beautifier.CoolLine();
                        Beautifier.CoolCenterLine("Dit inventar ser sådan her ud!", "blue");
                        Beautifier.CoolLine();
                        for (int i = 0; i < inventory.Count; i++)
                        {
                            Console.WriteLine(inventory[i].Name + " || " + inventory[i].HealthStat + " || " + inventory[i].StaminaStat + " || " + inventory[i].DrunkStat);
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (player_Answer == "no")
                {
                    inv_State = false;
                    Console.Clear();
                }
            }
        }

        public static void AddToInventory(Items item)
        {
            bool go = true;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (go)
                {
                    if (inventory[i].Name == "Empty_Slot" && !inventory.Contains(item))
                    {
                        inventory[i] = item;
                        Beautifier.CoolCenterLine($"{item.Name} Ligger nu i dit inventar!", "blue");
                        go = false;
                        //Player.Money -= item.Cost
                    }
                    else if (inventory.Contains(item))
                    {
                        Beautifier.CoolCenterLine($"Vi tillader ikke mere end en type genstand af gangen!", "red");
                        go = false;
                    }
                    else if (inventory[i].Name == "Empty_Slot")
                    {
                        Beautifier.CoolCenterLine($"Der er ikke mere plads i dine lommer!", "red");
                        go = false;
                    }
                }

            }
        }

        public static void PickFromInventory(Items item)
        {
            Sound.EatSound();
            Player.Eat(item);
            inventory.Remove(item);

            Items empty_slot = new Items("Empty_Slot", 0, 0, 0, false);
            inventory.Add(empty_slot);
        }
    }
}
