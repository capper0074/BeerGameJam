using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Character;
using GameJam.GameStart;
using GameJam.Graphic;
using GameJam.Levels;

namespace GameJam.Levels
{
    internal static class Bar
    {
      public static void Bartender() 
        {
            Console.Clear();
            Beautifier.CoolWrite("green","Narrator","White",$"{Player.Name} er lige kommet ud af toilettet og der er helt tomt i gangen.");
            Console.ReadKey();
            Beautifier.CoolWrite("Blue",$"{Player.Name}","White","Hvor meget fik jeg lige at drikke i går, mit hovede er ved at slå mig ihjel");
            Console.ReadKey();
            Beautifier.CoolWrite("green", "Narrator", "White", "Der er helt stille, bortset fra en svag lyd af nogen der bevæger sig, og klingen af flasker");
            Console.ReadKey();
            Beautifier.CoolWrite("blue",$"{Player.Name}","White","Når ja øl.. det skal nok få slukket hovedpinen indtil i aften.");
            Console.Clear();
            Console.ReadKey();
            Beautifier.CoolWrite("blue", $"{Player.Name}", "White", "Hej Ask? hvad laver du stadigvæk her?");
            Console.ReadKey();
            Beautifier.CoolWrite("Purple", "Ask", "white", $"hvad fanden, jeg kunne da spørge dig om det samme {Player.Name} ");
            Console.ReadKey(); 
            Beautifier.CoolWrite("blue", $"{Player.Name}", "White", "fair.. faldt i søvn på toilettet og vågnede op til en sur Rengøringsdame");
            Console.ReadKey(); 
            Beautifier.CoolWrite("purple", "Ask", "White", "Hun virkede hellere ikke som sig selv, mange af lærerne er også helt ude af den.. desuden er der nogen der har stjålet alle øl");
            Console.ReadKey(); 
            Beautifier.CoolWrite("blue", $"{Player.Name}", "white", "Ej...");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", $"{Player.Name}", "white", "Det mener du fandme ikke..");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", $"{Player.Name}", "white", "Har de vildeste tømmermænd og ved at en kold Odense Classic vil kunne bare tage lidt af den for nu");
            Console.ReadKey();
            Beautifier.CoolWrite("purple", "Ask", "White", "Så det godt jeg havde gemt nogen væk i nat, til at tage med hjem når jeg var færdig her");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", $"{Player.Name}", "white", "Du er seriøst en engel, ku' jeg få en?");
            Console.ReadKey();
            Beautifier.CoolWrite("purple", "Ask", "white", "Tjaaa.. hvis du vil hjælpe mig med de ølkasser der er forsvundet så ja");
            Console.ReadKey(); 
            Beautifier.CoolWrite("blue", $"{Player.Name}", "white", "fuuuuck...");
            Console.ReadKey();
            Beautifier.CoolWrite("blue", $"{Player.Name}", "white", "Okay så, har du nogen idé om hvor de kunne være?");
            Console.ReadKey();
            Beautifier.CoolWrite("purple","Ask","white",$"Hvis jeg vidste det, så havde jeg nok hentet dem selv ik {Player.Name}.. dumbass ");
            Beautifier.CoolWrite("blue", $"{Player.Name}", "white", "fuuuuck...");
            Console.ReadKey();
        }

    }
}
