using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Graphic
{
    public static class AsciiArt
    {

        private static string intro = "  _____       _             \r\n |_   _|     | |            \r\n   | |  _ __ | |_ _ __ ___  \r\n   | | | '_ \\| __| '__/ _ \\ \r\n  _| |_| | | | |_| | | (_) |\r\n |_____|_| |_|\\__|_|  \\___/ \r\n                            \r\n                            ";

        private static string fredagsBar = "  ______            _                   _                \r\n |  ____|          | |                 | |               \r\n | |__ _ __ ___  __| | __ _  __ _ ___  | |__   __ _ _ __ \r\n |  __| '__/ _ \\/ _` |/ _` |/ _` / __| | '_ \\ / _` | '__|\r\n | |  | | |  __/ (_| | (_| | (_| \\__ \\ | |_) | (_| | |   \r\n |_|  |_|  \\___|\\__,_|\\__,_|\\__, |___/ |_.__/ \\__,_|_|   \r\n                             __/ |                       \r\n                            |___/                        ";

        private static string gameName = "  ____                                    \r\n |  _ \\                                   \r\n | |_) | ___  ___ _ __   _ __ _   _ _ __  \r\n |  _ < / _ \\/ _ \\ '__| | '__| | | | '_ \\ \r\n | |_) |  __/  __/ |    | |  | |_| | | | |\r\n |____/ \\___|\\___|_|    |_|   \\__,_|_| |_|\r\n                                          \r\n                                          ";
        
        public static void Ascii_Intro()
        {
            Console.WriteLine(intro);
        }

        public static void Ascii_Bar()
        {
            Console.WriteLine(fredagsBar);
        }

        public static void Ascii_Name() 
        {
            Console.WriteLine(gameName);
        }
    }
}
