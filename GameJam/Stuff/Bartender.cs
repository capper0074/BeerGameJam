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

            while (inv_State)
            {
                //Made a new menu system, so we can iteract with it.
                var player_Answer = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Har du lyst til at købe noget\n ---------------------------")
                    .PageSize(3)
                    .AddChoices("Ja", "Nej"));

                if (player_Answer == "Ja")
                {
                    Beautifier.CoolWrite("Purple","Ask","White",$"{Player.Name} Hvad laver du her? det lørdag min ven");
                    Console.ReadKey();
                    Beautifier.CoolWrite("purple","Ask","White","Er du faldet i søvn.. på toilettet... pinligt.");
                    Console.ReadKey();
                    Beautifier.CoolWrite("blue", Player.Name, "White", "Hvorfor er det seriøst alle skal være efter mig i dag.");
                    Console.ReadKey();
                    Beautifier.CoolWrite("blue", Player.Name, "White", "Først rengøringsdamen, så stemmerne i mit hoved og nu dig");
                    Console.ReadKey();
                    Beautifier.CoolWrite("purple", "Ask", "White", "Stemmerne.... sure... tænkte nok du havde et par skruer løst.");
                    Console.ReadKey();
                    Beautifier.CoolWrite("blue", Player.Name, "White", "Ej stop nu med at være efter mig altså. Kan du give mig en øl eller noget at få i maven?");
                    Console.ReadKey();
                    Beautifier.CoolWrite("purple", "Ask", "white", "næh");
                    Console.ReadKey();
                    Beautifier.CoolWrite("purple", "Ask", "white", "...");
                    Console.ReadKey();
                    Beautifier.CoolWrite("purple", "Ask", "white", "...");
                    Console.ReadKey();
                    Beautifier.CoolWrite("blue", Player.Name, "white", "...");
                    Console.ReadKey();
                    Beautifier.CoolWrite("blue", Player.Name, "white", "...");
                    Console.ReadKey();
                    Beautifier.CoolWrite("purple", "Ask", "white", "ej.. JK, har dog ikke meget tilbage af øllene der er nogen der har stjålet alle undtagen 4");
                    Console.ReadKey();
                    Beautifier.CoolWrite("blue", Player.Name, "white", "hit mig med en giffel og en bajer så");
                    Console.ReadKey();
                    Beautifier.CoolWrite("purple", "Ask", "white", "Gerne, hvis du hjælper mig med de øl der så jeg ikke får skæld ud af fest udvalget og skolen.");
                    Console.ReadKey();
                    Beautifier.CoolWrite("blue", Player.Name, "White", "det mener du fandme ik...");
                    Console.ReadKey();
                    Beautifier.CoolWrite("blue", Player.Name, "white", "*suk* .... fint skal have stoppet den her tømmermænd");
                    Console.ReadKey();

                    string choice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                        .Title("Vælg en genstand at købe \n ---------------------------")
                        .PageSize(5)
                        .AddChoices("Odense Classic", "Odense 1859", "Odense Pilsner", "En enkelt Pågens giffel", "Jumbo's Peperoni"));

                    foreach (Items item in BartenderInventory)
                        if (item.Name == choice)
                        {
                            Inventory.AddToInventory(item);
                        }
                    for (int i = 0; i < Inventory.inventory.Count; i++)
                    {
                        Console.WriteLine(Inventory.inventory[i].Name + " || " + Inventory.inventory[i].HealthStat + " || " + Inventory.inventory[i].StaminaStat + " || " + Inventory.inventory[i].DrunkStat);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (player_Answer == "Nej")
                {
                    Console.Clear();
                    inv_State = false;
                }
            }
        }

    }
}