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
        public static void GoIntoAbyg()
        {
            if (!BByg.HasBeen)
            {
                Beautifier.CoolCenterLine("Du har ikke adgang til bygning-A. . .", "red");
                BByg.DefaultMenu();
            }

            HasBeen = true;

            #region[Narration]
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} befinder sig udenfor a bygningen");
            Console.ReadKey();

            Beautifier.CoolWrite("green", "Narrator: ", "white", $"Forvirret kigger {Player.Name} sig omkring. ");

            //"Hvor der normalt var spækket med rygere, dejlige damer.. og mænd selvfølgelig," +
            //"var der nu mere tommere for mennesker end " +
            //$"{Player.Name}'s konto efter 2. dag i måneden.);

            Console.ReadKey();
            Beautifier.CoolWrite("blue", Player.Name, "white", "Hvad er det der foregår?");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", Player.Name, "white", "Hvor er alle rygerne og de dejlige damer... og mænd");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", Player.Name, "white", "UCL er fanme tommere end min konto 2. dag i måneden.");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", Player.Name, "white", "Jeg har ikke være så forvirret siden jeg tog svampe i sidste weekend.");
            Console.ReadKey();
            #endregion!
            string playerChoice = Beautifier.CoolMenu("", "gå ind i bygningen", "gå tilbage");
            if (playerChoice == "gå ind i bygningen")
            {
                #region[Narration]
                Controls.Control();
                GoToCanteen();
                #endregion
            }
            else if (playerChoice == "gåtilbage")
            {
                #region[Narration]
                Controls.Control();
                #endregion
                //Nyt sted her skal kaldes
            }
        }
        public static void GoToCanteen()
        {
            #region[Narration]
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} vælger at gå ind i A-bygningen og fortsætte til kantinen");
            Beautifier.CoolWrite("white", "");
            #endregion
        }
        public static void GoBack()
        {
            #region[Narration]
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} fortryder og vælger at gå tilbage");
            #endregion
        }

        //vi skal narrate at player er uden for. skal over til aByg
        // går over mod abyg
        // går ind i abygning
        //  

        // Himmel i alverdens farver 
        // Genkendelig men på samme tid langt fra den UCL player kender til
        // 
    }
}
