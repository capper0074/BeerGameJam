using GameJam.Character;
using GameJam.GameStart;
using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.GameStart;

namespace GameJam.Levels
{
    internal static class Boxen
    {
        public static void WakeUp()

        {
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvor Fuck er jeg?");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Og Fuck hvor er jeg tørstig.");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvad er det der lugter sådan?");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Sniff Sounds*");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Glurgg Glurgg* Lige hvad jeg havde brug for at slukke tørsten Odense Classic");
            Console.ReadKey();
            Console.Clear();

            Beautifier.CoolWrite("Green", "Narrator", "White", Player.Name + " Er en svagdrikker, en letvægt og er faldet i søvn på toilettet (What a pussy)");
            Beautifier.CoolWrite("Green", "Narrator", "White", "Han vågnede nu op lørdag morgen i Beerboxen, og kan hører nogen udenfor toiletdøren." + "\n");

            Beautifier.CoolWrite("Yellow", "*Bank Bank Bank*" + "\n");

            Console.ReadKey();
            Beautifier.CoolWrite("Red", "Rengørings Dame", "White", "Hvem er det der bruger mit toilet! ");
            Console.ReadKey();
            Beautifier.CoolWrite("Red", "Rengørings Dame", "White", "Jeg Kalder på vagterne!" + "\n");
            Console.ReadKey();
            Beautifier.CoolWrite("Green", "Narrator", "White", "Vores helt er nu mødt med 2 valg muligheder, \n hvad vælger han? er han en Pussy? eller går han ud og tager konflikten");
            string playerChoice = Beautifier.CoolMenu("", "Bliv ved med at gemme dig ind på toilettet?", "Gå ud og konfrontere Rengørings Damen");
            Controls.Control();
            if (playerChoice == "Bliv ved med at gemme dig ind på toilettet?") 
            {
                //Rengøringsdamen går videre, uden at der sker noget.
                throw new NotImplementedException();

            }
            else if (playerChoice == "Gå ud og konfrontere Rengørings Damen") 
            {
                //Vagterne kommer ikke, og du kæmper kun mod Rengøringsdamen.
                //Trigger Combat
                throw new NotImplementedException();
            }









        }
    }
}
