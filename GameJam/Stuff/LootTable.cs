using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public static class LootTable
    {
        private static List<Items> Drops;

        private static bool isInitialized;

        public static void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            if (!isInitialized)
            {
                isInitialized = true;
            }
        }
    }
}
