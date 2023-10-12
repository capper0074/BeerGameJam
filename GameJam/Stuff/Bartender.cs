using GameJam.Character;
using GameJam.Graphic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public static class Bartender
    {
        private static List<Items> BartenderInventory;
        private static bool IsInitialized;
        public static string[] inventoryArray { get; set; }
        public static void Initialize()
        {
            if (IsInitialized) return;

            else if (!IsInitialized)
            {
                BartenderInventory = GameItems.gameItemList;
            }
        }

        public static void DisplayInventory()
        {
            bool inv_State = true;

            while (inv_State == true)
            {
                //Made a new menu system, so we can iteract with it.
                var player_Answer = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Har du lyst til at købe noget\n ---------------------------")
                    .PageSize(2)
                    .AddChoices("Ja", "Nej"));

                if (player_Answer == "Ja")
                {
                    string choice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                        .Title("Vælg en genstand at købe \n ---------------------------")
                        .PageSize(5)
                        .AddChoices("Odense Classic", "Odense 1859", "Odense Pilsner", "En enkelt Pågens giffel", "Jumbo's Peperoni"));

                        foreach(Items item in BartenderInventory)
                            if(item.Name == choice)
                            Inventory.AddToInventory(item);

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (player_Answer == "no")
                {
                    Console.Clear();
                }
            }
        }

    }
}