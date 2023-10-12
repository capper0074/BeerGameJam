using GameJam.Character;
using GameJam.Graphic;
using GameJam.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.GameStart
{
    public static class StartMenu
    {
        public static void Menu()
        {

            bool state = true;

            while (state == true)
            {
                Sound.BeerRun();
                Console.Clear();
                AsciiArt.Ascii_Name();
                //Ascii_Art.Ascii_GameStart();
                //Made a new menu system, so we can iteract with it.
                var playerChoice = Beautifier.CoolMenu("Welcome to the beer game", "Start the game", "Exit the game");


                if (playerChoice == "Start the game")
                {
                    Console.Clear();
                    Info.GameInfo();
                    Console.WriteLine("Hvad hedder du?");
                    Player.Name = Console.ReadLine();
                    Console.Clear();
                    state = false;
                    Intro.StartIntro();


                }
                else if (playerChoice == "Exit the game")
                {
                    state = false;
                    Console.Clear();
                    Environment.Exit(0);
                    //SendKeys.SendWait("{ENTER}");

                }
            }
        }
    }
}
