using GameJam.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public static class LootTable
    {
        private static List<Items> Drops = new();

        private static bool isInitialized;

        public static void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            if (!isInitialized)
            {
                if (GameItems.isInitialized) 
                {
                    foreach (Items item in GameItems.gameItemList)
                    {
                        Drops.Add(item);
                    }
                }
                else
                {
                    return;
                }

                isInitialized = true;
            }

        }
        public static List<Items> GetDrops(int amount)
        {
            List<Items> temp = new List<Items>();

            Random random = new();
            if (Drops.Count == 0 || Drops == null)
            {
                for (int i = 0; i < amount; i++)
                {
                    Drops.Add(GameItems.gameItemList[random.Next(GameItems.gameItemList.Count)]);
                }
                temp = Drops;

                return temp;
            }
            else
            {
                Drops.Clear();

                for (int i = 0; i < amount; i++)
                {
                    Drops.Add(GameItems.gameItemList[random.Next(GameItems.gameItemList.Count)]);
                }
                temp = Drops;

                return temp;
            }
        }
    }
}
