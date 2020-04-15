using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters.PlayerChars;

namespace LoHEngine.MainGame
{
    public class View
    {
        public static void PrintStats(Hero hero)
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
Age:          {15}
SkillPoints:  {16}
Experience:   {17}
Gold:         {18}
Items:", hero.Identifier,
       hero.CurrentHealth, hero.MaxHealth,
       hero.CurrentMana, hero.MaxMana,
       hero.CurrentStamina, hero.MaxStamina,
       hero.Str,
       hero.Int,
       hero.Dex,
       hero.Speed,
       hero.Luck,
       hero.Defense,
       hero.Resistance,
       hero.Level,
       hero.Age,
       hero.SkillPoint,
       hero.Experience,
       hero.Gold);
            foreach (string item in hero.items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue....");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
