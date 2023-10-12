using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Graphic;
using GameJam.GameStart;
using GameJam.Character;
using Spectre.Console;

namespace GameJam.Levels
{
    public static class Intro
    {
        public static void StartIntro()
        {

            AsciiArt.Ascii_Intro();
            Beautifier.CoolWrite("green", "Narrator", "white", $"{Player.Name} er til fredagsbar i BeerBoxen.");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "white", "Svælget bliver smurt med tonsvis af Odense Classic.");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "white", "Han taber lidt for mange omgange beerpong.");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "white", "Øllen hober sig op og toilettet er den eneste udvej.");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "white", "Det sidste han ser, er sig selv i spejlet...");
            Console.ReadKey();
            Beautifier.CoolWrite("green","Narrator","White", "han falder omkuld med sin bajer i hånden.") ;
            Console.ReadKey();
            Controls.Control(); // husk at kalde Controls.Control hver gang vi skifter rum
            Boxen.WakeUp();

        }
    }
}
