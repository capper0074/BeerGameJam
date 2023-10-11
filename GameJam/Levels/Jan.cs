using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Character;
using GameJam.Graphic;
using GameJam.Character;

namespace GameJam.Levels
{
    public class PrinterLokale
    {
        public static void TalkToJan()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", "Du går ind i printerlokalet og støder ind i Jan" );
            Console.ReadKey();
            Beautifier.CoolWrite("blue", Player.name, "white", "Hvad er det du har i hånden Jan? :O");
            Console.ReadKey();
            Beautifier.CoolWrite("red", "Jan: ", "white", "Jeg har en odense classic i hånden!!");
            Console.ReadKey();
            //string playerChoice = Beautifier.CoolMenu("Hvad vil du nu", "Gå hjem", "Kig til højre"); //Implement menu with choices using beautifier methods
        }
    }
}
