using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public static class GameLost
    {

        public static void GameIsLost()
        {
            AsciiArt.Ascii_Lose();
            Console.WriteLine("U lost the game gg noob");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
