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
Defense:      {7}
Strength:     {8}
Intelligence: {9}
Dexterity:    {10}
Will:         {11}
Luck:         {12}
Level:        {13}
Age:          {14}
SkillPoints:  {15}
Experience:   {16}
Gold:         {17}
Items:", hero.Identifier,
       hero.CurrentHealth, hero.MaxHealth,
       hero.CurrentMana, hero.MaxMana,
       hero.CurrentStamina, hero.MaxStamina,
       hero.Defense,
       hero.Str,
       hero.Int,
       hero.Dex,
       hero.Will,
       hero.Luck,
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
