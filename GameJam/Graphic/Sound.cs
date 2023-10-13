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
            player.URL = @"C:\Users\cappe\source\repos\BeerGameJam\GameJam\Graphic\Sounds\Boss_Sound.mp3"; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }

        public static void Fight()
        {
            player.URL = @"C:\Users\cappe\source\repos\BeerGameJam\GameJam\Graphic\Sounds\Boss_Sound.mp3 "; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }

        public static void BeerRun()
        {
            player.URL = @"C:\Users\cappe\source\repos\BeerGameJam\GameJam\Graphic\Sounds\BeerRun_Sound.mp3"; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }

        public static void EatSound()
        {
            player.URL = @"C:\Users\cappe\source\repos\BeerGameJam\GameJam\Graphic\Sounds\Eating_Sound.mp3"; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }

        public static void LoseSound()
        {
            player.URL = @"C:\Users\cappe\source\repos\BeerGameJam\GameJam\Graphic\Sounds\Lose_Sound.mp3"; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }

        public static void Waiting_Sound()
        {
            player.URL = @"C:\Users\cappe\source\repos\BeerGameJam\GameJam\Graphic\Sounds\Waiting_Sound.mp3"; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }

        public static void Peeing_Sound()
        {
            player.URL = @"C:\Users\cappe\source\repos\BeerGameJam\GameJam\Graphic\Sounds\Peeing_Sound.mp3"; //Sæt jeres egen file path ind. Kan ikke få en relative til at virke
            player.controls.play();
        }

        public static void StopSound()
        {
            player.controls.stop();
        }


    }
}
