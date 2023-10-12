using GameJam.Character;
using GameJam.GameStart;
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
        private static int combatRounds = 0;

        private static bool combatState = true;

        public static bool StartCombat()
        {
            Console.Clear();
            Beautifier.CoolWrite("red", "Welcome to combat, hope u are ready");

            Creatures enemy = Enemy.Enemy_Pick();

            

            while(combatState == true)
            {
                

                if (Player.Health > 0)
                {

                    if (enemy.Enemy_Health > 0)//Det skal være en modstander.
                    {
                        
                        Console.WriteLine("The combat starts");

                        if(Player.Piss >= 70)
                        {
                            string playerChoice = Beautifier.CoolMenu("Special attack", "Ja", "Nej");

                            if(playerChoice == "Ja")
                            {
                                enemy.Enemy_Health -= 95;
                                Beautifier.CoolBarCombat(enemy.Enemy_Health, "Enemy health");
                            }
                            else if(playerChoice == "Nej")
                            {
                                Console.WriteLine($"U use your {WeaponSlot.DisplayName()} to attack {enemy.Name}");
                                Console.WriteLine($"U deal {WeaponSlot.DisplayStat()} to {enemy.Name}");
                                enemy.Enemy_Health -= WeaponSlot.DisplayStat();
                                Beautifier.CoolBarCombat(enemy.Enemy_Health, "Enemy health");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"U use your {WeaponSlot.DisplayName()} to attack {enemy.Name}");
                            Console.WriteLine($"U deal {WeaponSlot.DisplayStat()} to {enemy.Name}");
                            enemy.Enemy_Health -= WeaponSlot.DisplayStat();
                            Beautifier.CoolBarCombat(enemy.Enemy_Health, "Enemy health");
                            Console.ReadKey();
                        }

                        if (enemy.Enemy_Health > 0)
                        {
                            Console.WriteLine($"Now {enemy.Name} attacks u");
                            Console.WriteLine($"They deal a total of {enemy.Attack_Value} damage");
                            Player.Health -= enemy.Attack_Value;
                            Beautifier.CoolBarCombat(Player.Health, "Player health");
                            Console.ReadKey();

                            Console.WriteLine("This was round: " + combatRounds);
                            Console.ReadKey();
                            Console.Clear();
                            combatRounds += 1;
                        }

                        else if (enemy.Enemy_Health <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("U won the combat");
                            combatState = false;
                            return true; //u won
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("U won the combat");
                        combatState = false;
                        return true; //u won
                        
                    }

                }
                else
                {
                    Console.WriteLine("U lose combat noob");
                    combatState = false;
                    return false; //u lost
                    Console.Clear();
                    AsciiArt.Ascii_Lose();
                    StartMenu.Menu();
                }

                
            }
            return false;




        }
    }
}
