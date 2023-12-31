﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public static class GameItems
    {
        public static bool isInitialized;

        public static List<Items> gameItemList { get; private set; }
        public static List<Weapons> weaponList { get; private set; }

        public static void Initialize()
        {
            if (isInitialized)
            {
                return;
            }


            gameItemList = new List<Items>();

            weaponList = new List<Weapons>();

            if (!isInitialized)
            {

                #region[Game items initialized]
                Items oClassic = new("Odense Classic", 0, 2, 4, true);
                Items oPils = new("Odense Pilsner", 0, 2, 3, false);
                Items o1859 = new("Odense 1859", 0, 2, 5, false);
                Items giffel = new("En enkelt Pågens giffel", 1, 5, 0, true);
                Items pizzaSlice = new("Jumbo's Peperoni", 5, 3, 0, false);

                gameItemList.Add(oClassic);
                gameItemList.Add(oPils);
                gameItemList.Add(o1859);
                gameItemList.Add(giffel);
                gameItemList.Add(pizzaSlice);
                #endregion

                #region[Game weapons initialized]
                Weapons blueSword = new("Sværd", 17, "blueSword");
                Weapons boxingGloves = new("Boxe handske", 17, "boxing");
                Weapons gun = new("Pistol", 17, "gun");
                Weapons magicStaff = new("Magi stav", 17, "magic");

                weaponList.Add(blueSword);
                weaponList.Add(boxingGloves);
                weaponList.Add(gun);
                weaponList.Add(magicStaff);
                #endregion

                isInitialized = true;
            }
        }
    }
}
