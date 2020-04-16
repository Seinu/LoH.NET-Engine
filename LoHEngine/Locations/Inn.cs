using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters;

namespace LoHEngine.Locations
{
    class Inn
    {
        /// <summary>
        /// Here is our inn, which gives our hero a chance to rest
        /// </summary>
        /// <param name="hero">Our current hero</param>
        public static void Sleep(BaseCharacter hero, List<BaseCharacter> Party)
        {
            string answer = "";
            Console.Clear();
            Console.WriteLine("Hello and welcome to the Inn, it's 8 gold to stay");
            do
            {
                Console.WriteLine("What can I do for you?");
                Console.Write(@"
(R)est
(D)one
");
                answer = Console.ReadLine();
                Console.WriteLine();
                switch (answer)
                {
                    case "R":
                    case "r":
                        if (hero.Gold >= 8)
                        {
                            hero.Gold -= 8;
                            Console.WriteLine("Alright, enjoy your stay");

                            foreach (BaseCharacter partymember in Party)
                            {
                                partymember.CurrHP = partymember.MaxHP;
                                partymember.CurrMP = partymember.MaxMP;
                                partymember.CurrSP = partymember.MaxSP;
                            }
                                
                        }
                        else
                        {
                            Console.WriteLine("Hey you don't have enough gold!");
                        }
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Be careful out there!");
                        break;
                    default:
                        Console.WriteLine("What? I don't understand that.");
                        break;
                }

            }
            while (answer != "D" && answer != "d");
            Console.WriteLine("Press enter to continue......");
            Console.Clear();
        }
    }

}
