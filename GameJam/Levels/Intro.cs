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
            AsciiArt.Ascii_Intro();
            Beautifier.CoolWrite("green", "Narrator","white", $"{Player.Name} er til fredagsbar i BeerBoxen. \n " +
                "Svælget bliver smurt med tonsvis af Odense Classic. Han taber lidt for mange omgange beerpong.\n " +
                "Øllen hober sig op og toilettet er den eneste udvej. \n " +
                "Det sidste han ser, er sig selv i spejlet inden " +
                "han falder omkuld med sin bajer i hånden.");
            Controls.Control();
            WakingUp.WakeUp();
            
             

        }
    }
}
