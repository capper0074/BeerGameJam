﻿using GameJam.Graphic;
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

                Console.Clear();
                //Ascii_Art.Ascii_GameStart();
                //Made a new menu system, so we can iteract with it.
                var playerChoice = Beautifier.CoolMenu("Welcome to the beer game", "Start the game", "Exit the game");


                if (playerChoice == "Start the game")
                {
                    Console.Clear();
                    state = false;
                    //Intro.Game_Intro();


                }
                else if (playerChoice == "Exit the game")
                {
                    state = false;
                    Console.Clear();
                    Environment.Exit(0);
                    //SendKeys.SendWait("{ENTER}");

                }
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("U entered a wrong value plz try agian");
                    Console.Clear();
                }
            }
        }
    }
}
