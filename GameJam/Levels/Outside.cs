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
        public static void Weoutside()
        {
            Beautifier.CoolWrite("green", "Narrator", "White", Player.Name + "  Er nu kommet udenfor, Der er flere forskellige muligheder her.");
            Console.ReadKey();
 
            string playerChoice = Beautifier.CoolMenu("", "Gå mod A-bygning", "Gå mod den dystre skov");
            if (playerChoice == "Gå mod A-bygning")
            {
                Console.Clear();
                Beautifier.CoolWrite("Green", "Narrator", "White", $"Prøv bare at se {Player.Name} what a G Det fortjener en bajer");
                Controls.Control();
                AByg.GoIntoAbyg();
            }
            else if (playerChoice == "Gå mod den dystre skov")
            {
                Console.Clear();
                Beautifier.CoolWrite("Green", "Narrator", "White", $"Oooooh spooky, {Player.Name} tænker vi skal få noget liquid courage indenbords før vi fortsætter ");
                Controls.Control();
                Forest.Dystreskov();

            }
        }
    }
}
