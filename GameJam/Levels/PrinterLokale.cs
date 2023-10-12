﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Character;
using GameJam.Graphic;
using GameJam.Character;

namespace GameJam.Levels
{
    public static class PrinterLokale
    {
        public static void TalkToJan()
        {
            #region[Narration]
            Beautifier.CoolWrite("green", "Narrator: ", "white", "Du går ind i printerlokalet og støder ind i Jan" );
            Console.ReadKey();

            Beautifier.CoolWrite("blue", Player.Name, "white", "Hvad er det du har i hånden Jan? :O");
            Console.ReadKey();
            
            Beautifier.CoolWrite("red", "Jan: ", "white", "Jeg har en odense classic i hånden!!");
            Console.ReadKey();
            
            Beautifier.CoolWrite("blue", Player.Name, "white", "Du har stjålet min drink!!");
            Console.ReadKey();

            Beautifier.CoolWrite("red", "Jan: ", "white", "DU HAR STJÅLET MIN LIVSGLÆDE");
            Console.ReadKey();

            Beautifier.CoolWrite("blue", Player.Name, "white", "HVAD MENER DU JAN?!?!?");
            Console.ReadKey();

            Beautifier.CoolWrite("red", "Jan: ", "white", "DU HAR ÆNDRET I MINE UNIT TESTS, OG NU SKAL DU MÆRKE KONSEKVENSERNE!!");
            Console.ReadKey();
            #endregion
            string playerChoice = Beautifier.CoolMenu("Hvad har du tænkt dig at gøre?", "Flygt", "Flæk ham (combat)"); //"Flæk Ham" puts you into combat against Jan.
            if (playerChoice == "Flygt")
            {
                #region[Narration]
                Beautifier.CoolWrite("green", "Narrator", "white", "Jan teleporterer foran døren og forhindrer vores helt i at flygte");
                Console.ReadKey();

                Beautifier.CoolWrite("red", "Jan", "white", "Troede du virkelig, at du kunne flygte fra mig, selveste JBro?");
                Console.ReadKey();

                Beautifier.CoolWrite("red", "Jan", "white", "Hvis du vil igennem, så er det MIG du skal gennem først!");
                Console.ReadKey();
                #endregion
                //PUT HELTEN I COMBAT MOD JAN
                #region[Narration]
                Beautifier.CoolWrite("red", "Jan: ", "white", "NEEEEEEEJ DU BESEJREDE MIIIG");
                Beautifier.CoolWrite("green", "Narrator: ", "white", "Uden sin øl, tog Jan hjem for lave flere af sine online tutorials");
                #endregion

            }
            else if (playerChoice == "Flæk ham (combat)")
            {
                // Gå i combat mod jan
                bool PlayerHasWon = true;

                if (PlayerHasWon == true)
                {
                    #region[Narration]
                    Beautifier.CoolWrite("red", "Jan", "white", "NOOOOOOO, du besejrede miiiiigggg");
                    #endregion
                }
                else
                {
                    #region[Narration]
                    Beautifier.CoolWrite("red", "Jan", "white", "MUHAHAHAHA, DU ER EN SVANS!!! TROEDE DU SERIØST, AT DU KUNNE VINDE OVER MIG??");
                    #endregion
                }
            }
        }
    }
}
