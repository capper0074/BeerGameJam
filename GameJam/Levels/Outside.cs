using GameJam.Character;
using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Character;
using GameJam.GameStart;
using GameJam.Graphic;
using GameJam.Stuff;
using GameJam.Fighting;
using System.Security.Cryptography.X509Certificates;

namespace GameJam.Levels
{
    public static class Outside
    {
        public static string playerChoice;
        public static void WeOutside()
        {
            Beautifier.CoolWrite("green", "Narrator", "white", Player.Name + "  Er nu kommet udenfor.");
            Console.ReadKey();
            Beautifier.CoolWrite("white", $"Der var intet som så ud som det plejede...");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "white", $"Før lørdag var der himmel, men nu så {Player.Name} sæbebobbel lignende kubbel,\n som så ud til at afgrænse UCL fra omverdenen.");
            Console.ReadKey();
            Beautifier.CoolWrite("", $" Der er flere forskellige muligheder her.");
            Console.ReadKey();

            playerChoice = Beautifier.CoolMenu("", "Gå mod A-bygning", "Gå mod den dystre skov");
            if (playerChoice == "Gå mod A-bygning")
            {
                Console.Clear();
                Beautifier.CoolWrite("Green", "Narrator", "White", $"Prøv bare at se {Player.Name} what a G Det fortjener en bajer");
                Controls.Control();
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

                playerChoice = Beautifier.CoolMenu("", "gå ind i bygningen", "gå tilbage");
                if (playerChoice == "gå ind i bygningen")
                {
                    Controls.Control();
                    AByg.GoToCanteen();
                }
                else if (playerChoice == "gåtilbage")
                {
                    Controls.Control();
                    //Nyt sted her skal kaldes
                }
            }
            else if (playerChoice == "Gå mod den dystre skov")
            {
                Console.Clear();
                Beautifier.CoolWrite("Green", "Narrator", "White", $"Oooooh spooky, {Player.Name} tænker vi skal få noget liquid courage indenbords før vi fortsætter ");
                Controls.Control();
                Forest.Dystreskov();

            }

        }
        public static void GoUpToB()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} befinder sig udenfor B-bygningen");
            Console.ReadKey();

            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} tænker over om det er en god ide at gå ind i b bygningen eller ej? ");

            Beautifier.CoolWrite("blue", Player.Name, "white", "B bygningen er lige der, men er det nu også en god ide at gå derind?");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", Player.Name, "white", "Hvem ved hvad der kan gemme sig derinde?");
            Console.ReadKey();

            Beautifier.CoolWrite("green", "Narrator; ", "white", $"Så hvad vil du gøre {Player.Name}?");

            string playerChoice = Beautifier.CoolMenu("", "gå ind i bygningen", "gå tilbage");
            if (playerChoice == "gå ind i bygningen")
            {
                Controls.Control();
                BByg.GoIntoB();
            }
            else if (playerChoice == "gå tilbage")
            {
                Controls.Control();
                //Nyt sted her skal kaldes
            }
        }
    }
}
