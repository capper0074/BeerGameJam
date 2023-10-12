using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Character;
using GameJam.GameStart;
using GameJam.Graphic;


namespace GameJam.Levels
{
    internal static class Outside
    {
        public static void Weoutside() 
        {
            Beautifier.CoolWrite("green", "Narrator", "White", Player.Name + "  Er nu kommet udenfor, Der er flere forskellige muligheder her.");
            // lav 2 options A bygning/ Skoven
            string playerChoice = Beautifier.CoolMenu("","","");
            if (playerChoice == "" ) 
            { 
            }
        }
    }
}
