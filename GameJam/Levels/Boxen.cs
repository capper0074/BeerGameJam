using GameJam.Character;
using GameJam.GameStart;
using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GameJam.GameStart;

namespace GameJam.Levels
{
    internal static class Boxen
    {
        public static void WakeUp()
        {
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvor er jeg?");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Og fuck hvor er jeg tørstig.");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvad er det der dufter sådan?");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Sniff Sounds*");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Glurgg Glurgg* Lige hvad jeg havde brug for.... Odense Classic!!");
            Console.ReadKey();
            Console.Clear();

            Beautifier.CoolWrite("Green", "Narrator", "White", Player.Name + "  er en svagdrikker, en letvægt og er faldet i søvn på toilettet (What a pussy)");
            Beautifier.CoolWrite("Green", "Narrator", "White", "Han vågnede nu op lørdag morgen i Beerboxen, og kan hører nogen udenfor toiletdøren." + "\n");

            Beautifier.CoolWrite("Yellow", "*Bank Bank Bank*" + "\n");

            Console.ReadKey();
            Beautifier.CoolWrite("Red", "Rengørings Dame", "White", "Hvem er det der bruger mit toilet! ");
            Console.ReadKey();
            Beautifier.CoolWrite("Red", "Rengørings Dame", "White", "Jeg kalder på vagterne!" + "\n");
            Console.ReadKey();
            Beautifier.CoolWrite("Green", "Narrator", "White", Player.Name + "er nu mødt med 2 valg muligheder, \n hvad vælger han? er han en pussy? eller går han ud og tager konflikten");
            string playerChoice = Beautifier.CoolMenu("", "Bliv ved med at gemme dig ind på toilettet?", "Gå ud og konfrontere rengørings damen");
            if (playerChoice == "Bliv ved med at gemme dig ind på toilettet?")
            {
                //Rengøringsdamen går videre, uden at der sker noget.

                Beautifier.CoolWrite("green", "Narrator", "White", "Det virker til at hun løj omkring vagterne, hun går videre og du er nu en tøsedreng");

            }
            else if (playerChoice == "Gå ud og konfrontere Rengørings Damen")
            {
                //Vagterne kommer ikke, og du kæmper kun mod Rengøringsdamen.
                //Trigger Combat
                Beautifier.CoolWrite("green", "Narrator", "White", Player.Name + "    Er nu færdig med hans første fist fight, husk at efter hver aktion mister du stamina. " +
                    "\n");
                // loot drop
            }

            Beautifier.CoolWrite("Blue", Player.Name, "White", "Damn, hun var godt nok muggen");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Jeg ku' godt bruge en drink efter det der");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Måske jeg kan nuppe en fra baren?");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "White", Player.Name + "      ");

        }
    }
}
