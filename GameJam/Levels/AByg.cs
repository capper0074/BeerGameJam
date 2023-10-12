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
    public static class AByg  // kalder static for at undgå at instansering      
    {
        public static void GoIntoAbyg()
        {
            
        }
        public static void GoToCanteen()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} vælger at gå ind i A-bygningen og fortsætte til kantinen");


            Beautifier.CoolWrite("white", "");
        }
        public static void GoBack()
        {
            Beautifier.CoolWrite("green", "Narrator: ", "white", $"{Player.Name} fortryder og vælger at gå tilbage");
        }

        //vi skal narrate at player er uden for. skal over til aByg
        // går over mod abyg
        // går ind i abygning
        //  

        // Himmel i alverdens farver 
        // Genkendelig men på samme tid langt fra den UCL player kender til
        // 



    }


}
