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


            string playerChoice = Beautifier.CoolMenu("", "gå ind i bygningen", "gå tilbage");
            if (playerChoice == "gå ind i bygningen")
            {
                Controls.Control();
                //GoToCanteen();
            }
            else if (playerChoice == "gåtilbage")
            {
                Controls.Control();
                //Nyt sted her skal kaldes
            }
        } 
    }
}
