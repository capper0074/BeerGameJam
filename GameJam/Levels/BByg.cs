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


