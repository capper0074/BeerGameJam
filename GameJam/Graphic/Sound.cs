using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Graphic
{
    public static class Sound
    {
        public static void Test()
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

            player.URL = @"C:\Users\Casper\Source\Repos\BeerGameJam\GameJam\Graphic\Sounds\I_WILL_KILL.mp3"; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }
    }
}
