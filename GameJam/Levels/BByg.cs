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
        public static bool HasBeen { get; set; }
        private static void DefaultMenu()
        {
            var playerChoice = Beautifier.CoolMenu("Du er nu tilbage i bygning B", "Gå ind i Boxen", "Gå ind i Bygning A");
            if (playerChoice == "Gå ind i Boxen")
            {
                Boxen.GoIntoBoxen();
            }
            else if (playerChoice == "Gå ind i bygning A")
            {
                AByg.GoIntoAbyg();
            }

        }
        public static void GoIntoB()
        {
            if (HasBeen == true)
            {
                DefaultMenu();
            }
            else if (!HasBeen)
            {
                #region[Narration]
                Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} befinder sig udenfor b bygningen");
                Console.ReadKey();

                Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} tænker over om det er en god ide at gå ind i b bygningen eller ej? ");

                Beautifier.CoolWrite("blue", Player.Name, "white", "B bygningen er lige der, men er det nu også en god ide at gå derind?");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "white", "Hvem ved hvad der kan gemme sig derinde?");
                Console.ReadKey();
                Beautifier.CoolWrite("green", "Narrator; ", "white", $"Så hvad vil du gøre {Player.Name}?");
                #endregion
            }
            HasBeen = true;
        }
    }
}


