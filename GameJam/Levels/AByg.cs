using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Character;
using GameJam.GameStart;

namespace GameJam.Levels
{
    public static class AByg  // kalder static for at undgå at instansering      
    {
        public static void GoIntoAbyg()
        {

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

            string playerChoice = Beautifier.CoolMenu("", "gå ind i bygningen", "gå tilbage");
            if (playerChoice == "gå ind i bygningen")
            {
                Controls.Control();
                GoToCanteen();
            }
            else if (playerChoice == "gåtilbage")
            {
                Controls.Control();
                //Nyt sted her skal kaldes
            }
        }
        public static void GoToCanteen()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} vælger at gå ind i A-bygningen og fortsætte til kantinen");


            Beautifier.CoolWrite("white", "");
        }
        public static void GoBack()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} fortryder og vælger at gå tilbage");
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
