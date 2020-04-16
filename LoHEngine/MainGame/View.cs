using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters;

namespace LoHEngine.MainGame
{
    class View
    {
        public static void PrintStats(List<BaseCharacter> Party)
        {

            foreach (BaseCharacter partymember in Party)
            {
                Console.Clear();
                Console.Write(@"
Name: {0}
Hitpoints:  {1}/{2}
Mana:       {3}/{4}
Stamina:    {5}/{6}
Strength:     {7}
Intelligence: {8}
Dexterity:    {9}
Speed:        {10}
Luck:         {11}
Def:          {12}
Res:          {13}
Level:        {14}
SkillPoints:  {15}
Experience:   {16}
Gold:         {17}
Items:", partymember.Name,
       partymember.CurrHP, partymember.MaxHP,
       partymember.CurrMP, partymember.MaxMP,
       partymember.CurrSP, partymember.MaxSP,
       partymember.Str,
       partymember.Int,
       partymember.Dex,
       partymember.Speed,
       partymember.Luck,
       partymember.Defense,
       partymember.Resistance,
       partymember.LVL,
       //partymember.Age,
       partymember.SkillPoint,
       partymember.EXP,
       partymember.Gold);
                /*foreach (string item in hero.items)
                {
                    Console.WriteLine(item);
                }*/
                Console.WriteLine();
                Console.WriteLine("Press enter for next party member....");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue....");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
