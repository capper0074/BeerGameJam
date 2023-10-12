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
    public static class BByg
    {
        public static void GoToBbyg()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} befinder sig udenfor b bygningen");
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
                GoIntoB();
            }
            else if (playerChoice == "gåtilbage")
            {
                Controls.Control();
                //Nyt sted her skal kaldes
            }
        }
        public static void GoIntoB()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} siger fuck it og går ind i B-bygningen");


            Beautifier.CoolWrite("white", "");
        }
    
        public static void GoBack()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} fortryder og vælger at gå tilbage");
        }


        }
    }


