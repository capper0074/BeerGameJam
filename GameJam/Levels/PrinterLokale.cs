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

            Beautifier.CoolWrite("blue", Player.Name, "white", "Hvad er det du har i hånden Jan? :O");
            Console.ReadKey();
            
            Beautifier.CoolWrite("red", "Jan: ", "white", "Jeg har en odense classic i hånden!!");
            Console.ReadKey();
            
            Beautifier.CoolWrite("blue", Player.Name, "white", "Hvad fanden laver du med min yndlingsdrink?!?!");
            Console.ReadKey();
            
            Beautifier.CoolWrite("red", "Jan: ", "white", "Vil du have den, så kom og tag den");
            string playerChoice = Beautifier.CoolMenu("Hvad har du tænkt dig at gøre?", "Gå hjem", "Flæk ham (combat)"); //"Flæk Ham" puts you into combat against Jan.
        }
    }
}
