using GameJam.Character;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.GameStart
{
    public static class Controls
    {
        public static void Control() //Should popup when the player needs to do something
        {
            bool state = true;

            while (state == true)
            {

                //Made a new menu system, so we can iteract with it.
                var playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("What do u want to do?\n ---------------------------")
                    .PageSize(6)
                    .AddChoices("See your stats", "Continue", "See your inventory", "See your weapon", "Exit the game"));


                if (playerChoice == "See your stats") //See stats
                {
                    Player.Display_Stats();

                }
                else if (playerChoice == "Continue") //Move Command
                {
                    Console.Clear();
                    Run.Game_Tick();
                    state = false;

                }
                else if (playerChoice == "See your inventory") //Inventory
                {
                    Inventory.DisplayInventory();

                }
                else if (playerChoice == "See your weapon")
                {
                    throw new NotImplementedException();
                }
                else if (playerChoice == "Exit the game") //Exit
                {
                    state = false;
                    Console.Clear();
                    Environment.Exit(0);

                }

            }
        }


    }
}
