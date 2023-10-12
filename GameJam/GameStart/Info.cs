using GameJam.Graphic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.GameStart
{
    public static class Info
    {
        public static void GameInfo()
        {
            AsciiArt.Ascii_Name();
            Beautifier.CoolPanel("", "Hej og velkommen til dette eventyr");
            Console.ReadKey();
            Console.Clear();

            AsciiArt.Ascii_Name();
            Beautifier.CoolPanel("", "Lige for at hjælpe dig en smule får du lige nogle hinst\n " +
                "Først og fremmest, så husk at du skal få drukket nogle øl, da du mister stamina");
            Console.ReadKey();
            Console.Clear();
        }




    }
}
