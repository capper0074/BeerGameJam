using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Graphic;
using GameJam.GameStart;

namespace GameJam.Levels
{
    public static class Intro
    {
        public static void StartIntro()
        {
            var playerChoice = Beautifier.CoolMenu("What u want", "Valg1", "Valg2");

            if (playerChoice == "Valg1")
            {
                Controls.Control();
            }
            else if (playerChoice == "Valg2")
            {
                Console.WriteLine("Umm waht");
            }
        }
    }
}
