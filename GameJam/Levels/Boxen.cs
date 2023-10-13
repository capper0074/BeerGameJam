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
using Spectre.Console;
using GameJam.Stuff;

namespace GameJam.Levels
{
    internal static class Boxen
    {
        public static bool HasBeen { get; set; }

        public static bool HasBeenBar { get; set; }
        private static void DefaultMenu()
        {
            string playerChoice = Beautifier.CoolMenu("Velkommen til Boxen", "Gå over til Baren", "Gå udenfor");
            if (playerChoice == "Gå over til Baren")
            {
                //No Control here
                Bar();
            }
            else if (playerChoice == "Gå udenfor")
            {
                Controls.Control();
                Outside.GoOutside();
            }
        }

        public static void GoIntoBoxen()
        {
            if (HasBeen)
            {
                DefaultMenu();
            }
            else if (!HasBeen)
            {
                Beautifier.CoolWrite("yellow", "Velkommen til Boxen, intro intro du har ikke været her før");

                DefaultMenu();
            }
            HasBeen = true;
        }
        public static void WakeUp()
        {
            HasBeen = true;

            #region[Narration]
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvor er jeg?");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Og fuck hvor er jeg tørstig.");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Hvad er det der dufter sådan?");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Sniff Sniff*");
            Sound.Sniff_Sound();
            Thread.Sleep(4000);
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Glurgg Glurgg* Lige hvad jeg havde brug for.... Odense Classic!!");
            Sound.Drinking_Sound();
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
            #endregion
            Beautifier.CoolWrite("Green", "Narrator", "White", $" {Player.Name} er nu mødt med 2 valgmuligheder, \n hvad vælger du? er du en pussy? eller går du ud og tager konflikten");
            
            string playerChoice1 = Beautifier.CoolMenu("", "Bliv ved med at gemme dig ind på toilettet?", "Gå ud og konfrontere rengørings damen");
            if (playerChoice1 == "Bliv ved med at gemme dig ind på toilettet?")
            {
                #region[Narration]
                //Rengøringsdamen går videre, uden at der sker noget.

                Beautifier.CoolWrite("green", "Narrator", "White", $"Det virker til at hun løj omkring vagterne, hun går videre og {Player.Name} er nu en tøsedreng");
                #endregion
            }
            else if (playerChoice1 == "Gå ud og konfronter rengørings damen")
            {
                Controls.Control();

                bool combatState = Combat.StartCombat();

                if (combatState == true)
                {
                    #region[Narration]
                    Beautifier.CoolWrite("green", "Narrator", "White", $"{Player.Name} Er nu færdig med hans første fist fight, husk at efter hver aktion mister du stamina. " +
                        "\n");
                    #endregion
                }
                else
                {
                    GameLost.GameIsLost();
                }


                // loot drop

            }

            #region[Narration]
            Beautifier.CoolWrite("Blue", Player.Name, "White", "Damn, hun var godt nok muggen");
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
            #endregion
            DefaultMenu();
        }

        //<-----------BAREN------------>

        public static void Bar()
        {
            if (HasBeenBar) { BarMenu(); }
            else if (!HasBeenBar) 
            { 
                Beautifier.CoolCenterLine("Baren er det bedste sted på jorden, kom hid kom hid sluk din tørst", "yellow");
                Beautifier.CoolLine();
                Console.ReadKey();
                Console.Clear();

                HasBeenBar = true;

                BarMenu();
            }
        }
        
        public static void BarMenu()
        {
            Bartender.DisplayInventory();
            Beautifier.CoolWrite("blue", "Du bevæger dig tilbage til Boxen");
            Controls.Control();
            DefaultMenu();
        }
    }
}
