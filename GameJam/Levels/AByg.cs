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
    public static class AByg 
    {
        public static bool HasBeen { get; set; }

        private static void DefaultMenu()
        {
            if (HasBeen)
            {
                var playerChoice = Beautifier.CoolMenu("Du er nu tilbage i bygning B", "gå ind i Boxen", "gå ind i Bygning A");
                if (playerChoice == "gå ind i Boxen")
                {
                    Boxen.GoIntoBoxen();
                }
                else if (playerChoice == "gå ind i bygning A")
                {
                    AByg.GoIntoAbyg();
                }
            }
        }
        public static void GoIntoAbyg()
        {
            if (HasBeen)
            {
                DefaultMenu();
            }
            else if (!HasBeen)
            {
                #region[Narration]
                //Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} befinder sig udenfor a bygningen");
                //Console.ReadKey();

                //Beautifier.CoolWrite("green", "Narrator: ", "white", $"Forvirret kigger {Player.Name} sig omkring. ");

                ////"Hvor der normalt var spækket med rygere, dejlige damer.. og mænd selvfølgelig," +
                ////"var der nu mere tommere for mennesker end " +
                ////$"{Player.Name}'s konto efter 2. dag i måneden.);

                //Console.ReadKey();
                //Beautifier.CoolWrite("blue", Player.Name, "white", "Hvad er det der foregår?");
                //Console.ReadKey();
                //Beautifier.CoolWrite("blue", Player.Name, "white", "Hvor er alle rygerne og de dejlige damer... og mænd");
                //Console.ReadKey();
                //Beautifier.CoolWrite("blue", Player.Name, "white", "UCL er fanme tommere end min konto 2. dag i måneden.");
                //Console.ReadKey();
                //Beautifier.CoolWrite("blue", Player.Name, "white", "Jeg har ikke være så forvirret siden jeg tog svampe i sidste weekend.");
                //Console.ReadKey();
                #endregion!
                DefaultMenu();
            }
            HasBeen = true;
        }
    }
}
