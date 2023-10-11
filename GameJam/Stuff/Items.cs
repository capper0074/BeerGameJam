using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    internal class Items
    {
        public string Name { get; set; }
        public int ItemStat { get; set; }

        public Items(string name, int itemstat)
        {
            Name = name;
            ItemStat = itemstat;
        }
    }
}
