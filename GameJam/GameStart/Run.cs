using GameJam.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.GameStart
{
    public static class Run
    {

        public static void Game_Tick() //For things witch need to tick when the game runs
        {
            Player.Tick_Stamina();
        }

        public static void StartGame()
        {
            Player.Initialize();
            Inventory.Initialize();


            StartMenu.Menu();
        }

    }
}
