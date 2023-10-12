using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Fighting;
using GameJam.Graphic;
using GameJam.Stuff;
using GameJam.Levels;
using GameJam.Character;



namespace GameJam.Levels
{
    internal class Forest
    {
        public static void Dystreskov() 
        {
            #region[Narration]
            Beautifier.CoolWrite("blue", Player.Name, "White", "fuck der er mørkt her! hvem har slukket lyset..");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "*Råber* Er der nogen der har en lighter?!");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", Player.Name, "White", "");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue", Player.Name, "White", "");
            Console.ReadKey();
            #endregion
        }
    }
}
