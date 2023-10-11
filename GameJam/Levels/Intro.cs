using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Graphic;
using GameJam.GameStart;
using GameJam.Character;

namespace GameJam.Levels
{
    public static class Intro
    {
        public static void StartIntro()
        {
            Beautifier.CoolWrite("red", $"{Player.name}");
            string playerChoice = Beautifier.CoolMenu("What u want", "Valg1", "Show inventory");

            if (playerChoice == "Valg1")
            {
                Controls.Control();
            }
            else if (playerChoice == "Show inventory")
            {
                Controls.Control(); 
            }
        }
    }
}
