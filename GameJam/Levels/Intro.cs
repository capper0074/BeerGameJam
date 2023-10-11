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
            Beautifier.CoolLoadingScreen(20);

            AsciiArt.Ascii_Intro();
            Beautifier.CoolWrite("green", "Narrator","white", $"{Player.Name} er til fredagsbar i BeerBoxen. \n " +
                "Svælget bliver smurt med tonsvis af Odense Classic. Han taber lidt for mange omgange beerpong.\n " +
                "Øllen hober sig op og toilettet er den eneste udvej. \n " +
                "Det sidste han ser, er sig selv i spejlet inden " +
                "han falder omkuld med sin bajer i hånden.");
            Controls.Control(); // husk at kalde Controls.Control hver gang vi skifter rum
            WakingUp.WakeUp();
        }
    }
}
