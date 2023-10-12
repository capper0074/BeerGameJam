using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public class Weapons
    {
        public string Name { get; set; }

        public string AssetName { get; set; }

        public int Weapon_Attack { get; set; }

        public Weapons(string name, int weapon_Attack, string assetName)
        {
            Name = name;
            Weapon_Attack = weapon_Attack;
            AssetName = assetName;
        }
    }
}
