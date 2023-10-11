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
            Beautifier.CoolWrite("green", $"{Player.name} er til fredagsbar i BeerBoxen. \n " +
                $"Svælget bliver smurt med tonsvis af Odense Classic. Han taber lidt for mange \n " +
                $"omgange beerpong. Øllen hober sig op og toilettet er den eneste udvej \n");
            
            string playerChoice = Beautifier.CoolMenu("What u want", "Valg1", "Show inventory");

            if (playerChoice == "Valg1")
            {
                Controls.Control();
            }
            else if (playerChoice == "Show inventory")
            {
                Controls.Control();
            } 

            //
        }
    }
}
