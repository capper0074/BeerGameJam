using GameJam.Character;
using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Fighting
{
    public static class Combat
    {
        public static bool StartCombat()
        {
            Beautifier.CoolWrite("red", "Welcome to combat, hope u are ready");

            Creatures enemy = Enemy.Enemy_Pick();

            bool combatState = true;

            while(combatState == true)
            {
                if (Player.Health < 0)
                {

                    if (enemy.Enemy_Health < 0)//Det skal være en modstander.
                    {
                        int combatRounds = 0;
                        Console.WriteLine("The combat starts");
                        Console.WriteLine($"U use your {WeaponSlot.DisplayName} to attack {enemy.Name}");
                        Console.WriteLine($"U deal {WeaponSlot.DisplayStat} to {enemy.Name}");
                        Beautifier.CoolBarCombat(enemy.Enemy_Health,"Enemy health");

                        Console.WriteLine($"Now {enemy.Name} attacks u");
                        Console.WriteLine($"They deal a total of {enemy.Attack_Value} damage");
                        Beautifier.CoolBarCombat(Player.Health, "Player health");

                        Console.WriteLine("This was round: " + combatRounds);
                        Console.ReadKey();
                        combatRounds++;
                    }
                    else
                    {
                        Console.WriteLine("U won the combat");
                        return true; //u won
                        combatState = false;
                    }

                }
                else
                {
                    Console.WriteLine("U lose combat noob");
                    return false; //u lost
                    combatState = false;
                }

                
            }
            return false;




        }
    }
}
