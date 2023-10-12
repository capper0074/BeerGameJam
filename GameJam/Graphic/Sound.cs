using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Graphic
{
    public static class Sound
    {
        private static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public static void Test()
        {
            player.URL = @"C:\Users\cappe\source\repos\BeerGameJam\GameJam\Graphic\Sounds\I_WILL_KILL.mp3"; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }

        public static void StopSound()
        {
            player.controls.stop();
        }


    }
}
