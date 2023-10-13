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



namespace GameJam.Levels
{
    public static class Outside
    {
        public static bool HasBeen { get; set; }
        public static void DefaultMenu()
        {

            string playerChoice = Beautifier.CoolMenu("Du er nu tilbage udenfor", "Gå ind i bygning A", "Gå ind i bygning B", "Gå ind i Boxen");
            {
                if (playerChoice == "Gå ind i bygning A")
                {
                    Controls.Control();
                    AByg.GoIntoAbyg();
                }
                else if (playerChoice == "Gå ind bygning B")
                {
                    Controls.Control();
                    BByg.GoIntoB();
                }
                else if (playerChoice == "Gå ind i Boxen")
                {
                    Boxen.GoIntoBoxen();
                }
            }

        }

        public static void GoOutside()
        {
            if (HasBeen)
            {
                DefaultMenu();
            }
            else if (!HasBeen)
            {
                Console.Clear();
                Beautifier.CoolWrite("green", "Narrator", "white", Player.Name + "står nu udenfor. Du har valgmulighederne at gå i bygning A, Bygning B, boxen. ");
                DefaultMenu();
            }
            
            //Decide if this Narration can be reused
            #region[Narration]
            //    Beautifier.CoolWrite("green", "Narrator", "white", Player.Name + "  Er nu kommet udenfor.");
            //Console.ReadKey();
            //Beautifier.CoolWrite("white", $"Der var intet som så ud som det plejede...");
            //Console.ReadKey();
            //Beautifier.CoolWrite("green", "Narrator", "white", $"Før lørdag var der himmel, men nu så {Player.Name} sæbebobbel lignende kubbel,\n som så ud til at afgrænse UCL fra omverdenen.");
            //Console.ReadKey();
            //Beautifier.CoolWrite("", $" Der er flere forskellige muligheder her.");
            Console.ReadKey();
            #endregion
            #region[Narration]
            //Console.Clear();
            //Beautifier.CoolWrite("Green", "Narrator", "White", $"Prøv bare at se {Player.Name} what a G Det fortjener en bajer");
            //Controls.Control();
            //AByg.GoIntoAbyg();
            #endregion
            #region[Narration]
            //Console.Clear();
            //Beautifier.CoolWrite("Green", "Narrator", "White", $"Oooooh spooky, {Player.Name} tænker vi skal få noget liquid courage indenbords før vi fortsætter ");
            //Controls.Control();
            //Forest.Dystreskov();
            #endregion
        } 
    }
}

