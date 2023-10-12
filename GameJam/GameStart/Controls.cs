using GameJam.Character;
using GameJam.Graphic;
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

            string playerChoice = "";

            while (state == true)
            {
                
                if (Player.Piss >= 20)
                {
                    Beautifier.CoolLine();
                    playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                        .Title("What do u want to do?")
                        .PageSize(7)
                        .AddChoices("See your stats", "Continue", "See your inventory", "See your weapon", "Take a piss", "Exit the game"));
                }
                else
                {
                    Beautifier.CoolLine();
                    playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                        .Title("What do u want to do?")
                        .PageSize(6)
                        .AddChoices("See your stats", "Continue", "See your inventory", "See your weapon", "Exit the game"));
                }
                Console.Clear();


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
                    WeaponSlot.DisplayCurrentWeapon();
                }
                else if (playerChoice == "Take a piss")
                {
                    Console.WriteLine("You just took a huge piss");
                    Player.TakeAPiss();
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
