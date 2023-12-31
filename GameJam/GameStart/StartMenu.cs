﻿using GameJam.Character;
using GameJam.Graphic;
using GameJam.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                string playerChoice = Beautifier.CoolMenu("Welcome to the beer game", "Start the game", "Exit the game");

                bool loopStage = true; 

                if (playerChoice == "Start the game")
                {
                    Console.Clear();
                    Info.GameInfo();

                    while (loopStage == true)
                    {
                        Beautifier.CoolCenterLine("Hvad hedder du?", "blue");
                        Player.Name = Console.ReadLine();
                        if (Player.Name == "")
                        {
                            Console.WriteLine("Er du dum? Skriv dit navn!");
                            Console.ReadKey();
                            Console.Clear();
                            loopStage = true;
                        }
                        else
                        {
                            loopStage = false;
                        }
                    }

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
