using GameJam.Character;
using GameJam.Fighting;
using GameJam.Stuff;
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
            Player.Tick_Piss();
            Player.Tick_PissDamage();
        }

        public static void StartGame()
        {
            GameItems.Initialize();
            //LootTable.Initialize();
            WeaponSlot.Initialize();
            Player.Initialize();
            Enemy.Initialize();
            Inventory.Initialize();

            StartMenu.Menu();
        }

    }
}
