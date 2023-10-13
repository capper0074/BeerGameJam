using GameJam.Character;
using GameJam.GameStart;
using GameJam.Graphic;
using System;
using GameJam.Fighting;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GameJam.Levels;
using GameJam.Stuff;

namespace GameJam.Levels
{
    internal static class Boxen
    {
        public static void WakeUp()
        {
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvor er jeg?");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "... og fuck hvor er jeg tørstig.");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvad er det der dufter sådan?");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Sniff Sniff*");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Glurgg Glurgg* Lige hvad jeg havde brug for.... Odense Classic!!");
            Console.ReadKey();
            Console.Clear();

            Beautifier.CoolWrite("Green", "Narrator", "White", $"{Player.Name} er en svagdrikker, en letvægt og er faldet i søvn på toilettet (What a pussy)");
            Console.ReadKey();
            Beautifier.CoolWrite("Green", "Narrator", "White", "Han vågnede nu op lørdag morgen i Beerboxen, og kan hører nogen udenfor toiletdøren." + "\n");
            Console.ReadKey();
            Beautifier.CoolWrite("Yellow", "*Bank Bank Bank*" + "\n");

            Console.ReadKey();
            Beautifier.CoolWrite("Red", "Fremmed", "White", "\"HALLO!\" ");
            Console.ReadKey();
            Beautifier.CoolWrite("Red", "Fremmed", "White", "Kom ud fra toilettet! Det er rengøringsdag! Giv mig din pant! ");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvem er det? ");

            Beautifier.CoolWrite("Blue", Player.Name, "White", "...");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "...");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "ReNgøRiNgS DaMeeeN!!");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "\"Skrub AAFF! Umuligt du får min ØLLL!!\"");
            Console.ReadKey();
            Beautifier.CoolWrite("Red", "Rengørings Dame", "White", "\"Pant!, eller jeg kalder på vagterne!\"" + "\n");
            Console.ReadKey();
            Beautifier.CoolWrite("Green", "Narrator", "White", $" {Player.Name} er nu mødt med 2 valg muligheder, \n hvad vælger du? er du en pussy? eller går du ud og tager konflikten");
            string playerChoice1 = Beautifier.CoolMenu("", "Bliv ved med at gemme dig ind på toilettet?", "Gå ud og konfrontere rengørings damen");
            Console.Clear();
            if (playerChoice1 == "Bliv ved med at gemme dig ind på toilettet?")
            {
                //Rengøringsdamen går videre, uden at der sker noget.

                Beautifier.CoolWrite("green", "Narrator", "White", $"Det virker til at hun løj omkring vagterne, hun går videre og {Player.Name} er nu en tøsedreng");

            }
            else if (playerChoice1 == "Gå ud og konfrontere rengørings damen")
            {
                bool combatState = Combat.StartCombat();

                if (combatState == true)
                {
                    Beautifier.CoolWrite("green", "Narrator", "White", $"{Player.Name} Er nu færdig med hans første fist fight, husk at efter hver aktion mister du stamina. " +
                                        "\n");
                }
                else if (combatState == false)
                {
                    Console.Clear();
                    GameLost.GameIsLost();
                }

            }

            Beautifier.CoolWrite("Blue", Player.Name, "White", "Damn, hun var godt nok muggen, b***h");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Jeg ku' godt bruge en drink efter det der");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Måske jeg kan nuppe en fra baren?");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "White", "Alti' en god idé med en øl.");
            Console.ReadKey();
            Beautifier.CoolWrite("green","Narrator","white","*Du har nu fri tøjler til at vælge lige der hvor ");
            Beautifier.CoolWrite("green", "Narrator", "White", "Det vil sige du kan gå hen til baren, eller.....?");
            Beautifier.CoolWrite("blue", $"{Player.Name}", "White", "eller...? hvad, afslut din sætning");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "White", "Hvis du nu ikke afbrød mig, som en 8 årig i Disneyland så kunne jeg fortælle hvad ellers. ik?");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "White", $"Nå så kan {Player.Name} ikke komme med noget smart mere hva?");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", $"Blue", "White", "havde lige munden fuld af din mor, men go on");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "White", "*suk* ....");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "White", "Hvor kom jeg fra.. nå ja, eller du kan gå rundt udenfor og se hvad for nogle andre områder der er adgang til");
            Console.ReadKey();
            Console.Clear();
            string PlayerChoice2 = Beautifier.CoolMenu("", "Gå hen mod baren og se om der er flere øl tilbage fra gårdagen's fredagsbar.", "udforsk området udenfor.");
            if (PlayerChoice2 == "Gå hen mod baren og se om der er flere øl tilbage fra gårdagen's fredagsbar.")
            {
                Beautifier.CoolWrite("green", "Narrator", "White", $"SMH der er ingen ryggrad at finde på {Player.Name} sådan en duks som altid gør hvad der bliver sagt.");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", $"{Player.Name}", "White", "årh.. så hold dog kæft, skal have skruet ned for tømmermænden på den eneste rigtiger måde");
                Console.ReadKey();
                Beautifier.CoolWrite("blue",$"{Player.Name}","White","flere bajere");
                Console.ReadKey();
                Bar.Bartender();
                Controls.Control();
            }
            else if (PlayerChoice2 == "udforsk området udenfor.")
            {
                Beautifier.CoolWrite("green", "Narrator", "White", "What a rebel.");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", $"{Player.Name}", "White", "You know it.");
                Console.ReadKey();
                Outside.Weoutside();
                Controls.Control();
            }
        }
        public static void Gåtilbage() 
        {
            
        }
    }
}
