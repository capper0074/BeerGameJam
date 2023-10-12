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
            Sound.Test();

            AsciiArt.Ascii_Intro();
            Beautifier.CoolWrite("green", "Narrator", "white", $"\n{Player.Name} er til fredagsbar i BeerBoxen.");
            Console.ReadKey();
            Beautifier.CoolWrite("white", "Svælget bliver smurt med tonsvis af Odense Classic.");
            Console.ReadKey();
            Beautifier.CoolWrite("white", "Han taber lidt for mange omgange beerpong.");
            Console.ReadKey();
            Beautifier.CoolWrite("white", "Øllen hober sig op og toilettet er den eneste udvej.");
            Console.ReadKey();
            Beautifier.CoolWrite("white", "Det sidste han ser, er sig selv i spejlet inden \n " +
                "han falder omkuld med sin bajer i hånden.");
            Console.ReadKey();
            Controls.Control(); // husk at kalde Controls.Control hver gang vi skifter rum
            Boxen.WakeUp();

        }
    }
}
