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
                foreach (var item in GameItems.gameItemList)
                {
                    if (item.IsStartingItem)
                    {
                        inventory.Add(item);
                    }
                }

                Items empty_slot = new Items("Empty_Slot", 0, 0, 0, true);

                for (int i = 0; i < 10 - inventory.Count; i++)
                {
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
                    .Title("Do you want to use anything from your inventroy\n ---------------------------")
                    .PageSize(3)
                    .AddChoices("yes", "no"));

                if (player_Answer == "yes")
                {
                    bool player_state = true;

                    while (player_state == true)
                    {
                        var inv_index = AnsiConsole.Prompt(new SelectionPrompt<string>()
                            .Title("Choose what u want from your inventory \n ---------------------------")
                            .PageSize(7)
                            .AddChoices(inventory[0].Name, inventory[1].Name, inventory[2].Name, inventory[3].Name, inventory[4].Name, inventory[5].Name, inventory[6].Name));

                        if (inv_index == "Empty_Slot")
                        {
                            Console.Clear();
                            Beautifier.CoolWrite("red", "U dont have anything in that slot");
                            player_state = true;
                        }
                        else if (inv_index != "Empty_Slot")
                        {
                            int index = inventory.FindIndex(item => item.Name == inv_index);
                            PickFromInventory(inventory[index]);
                            player_state = false;
                        }
                    }
                    inv_State = false;
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
                if(go)
                {
                    if (inventory[i].Name == "Empty_Slot" && !inventory.Contains(item))
                    {
                        inventory[i] = item;
                        Beautifier.CoolWrite("yellow", $"{item.Name} Ligger nu i dit inventar!");
                        go = false;
                        //Player.Money -= item.Cost
                    }
                    else if (inventory.Contains(item))
                    {
                        Beautifier.CoolWrite("red", $"{item.Name} Vi tillader ikke mere end en type genstand af gangen!");
                        go = false;
                    }
                    else if (inventory[i].Name == "Empty_Slot")
                    {
                        Beautifier.CoolWrite("red", $"{item.Name} Der er ikke mere plads i dine lommer!");
                        go = false;
                    }
                }

            }
        }

            public static void PickFromInventory(Items item)
            {
                Sound.EatSound();
                Player.Eat(item);
                for (int i = 0; i < inventory.Count; i++) //This only works if you can only have one item per item type in your inventory
                {
                    if (inventory[i] == item)
                        inventory.Insert(i, item);
                }
                inventory.Remove(item);
                Items empty_slot = new Items("Empty_Slot", 0, 0, 0, false);
                inventory.Add(empty_slot);
            }
        }
    }
