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
                Controls.Control();
                Boxen.GoIntoBoxen();
            }
            else if (playerChoice == "Gå ind i bygning A")
            {
                Controls.Control();
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
                Console.ReadKey();
                Beautifier.CoolWrite("blue",Player.Name,"White","Måske jeg skulle lade være med at være en lil' bitch");
                Beautifier.CoolWrite("green", "Narrator", "White", $"{Player.Name} går ind i bygningen nu og det er som om nogen har skruet ned for lysstyrken");
                Console.ReadKey();
                Beautifier.CoolWrite("green", "Narrator", "white", "Desuden er det som om han bliver skubbet tilbage til udgangen, det virker til at bygningen ikke vil have dig til at gå videre.");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "White", "Hvad fuck, hvem er det der fronter mig");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "White", "Stop dog med at skubbe?");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "White", "HALLO!");
                Console.ReadKey();
                Beautifier.CoolWrite("green", "Narrator", "White", $"{Player.Name} er godt nok lidt hidsig i hans tone.");
                Console.ReadKey();
                Beautifier.CoolWrite("green", "Narrator", "white", "Men det er rigtigt, du bliver faktisk skubbet. ");
                Console.ReadKey();
                Beautifier.CoolWrite("green","Narrator","White","Jeg tror hellere ikke du er stærk nok endnu til at komme videre herfra");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "White", "Hvad skulle det betyde, tror du jeg er en svans? Jeg går i fitness!");
                Console.ReadKey();
                Beautifier.CoolWrite("green", "Narrator", "White", "Vi ved allesammen godt at det er mere donationer til Puregym end et abonnement med hvor lidt du viser dit ansigt der.");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "White", "Årh så hold dog kæft, tager da der ind tit");
                Console.ReadKey();
                Beautifier.CoolWrite("green", "Narrator", "White", "Lige så tit som du scorer ja.");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "White", "Broo.. ik cool");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "White", "fint, skal nok gå ud.");
                Console.ReadKey();
                Beautifier.CoolWrite("blue", Player.Name, "White", "*Åbner en øl* skål til det i guess..");
                Console.ReadKey();
                #endregion
            }
            HasBeen = true;
        }
    }
}


