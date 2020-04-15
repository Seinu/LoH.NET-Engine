using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters;

namespace LoHEngine.Characters.PlayerChars
{
    public class Hero : Character
    {
        public List<string> items;
        public Hero()
        {
            items = new List<string>();
        }
        public static void Initialize(Hero hero)
        {
            hero.isGM = false;


            hero.CurrentHealth = 21;
            hero.MaxHealth = 21;
            hero.CurrentMana = 21;
            hero.MaxMana = 21;
            hero.CurrentStamina = 21;
            hero.MaxStamina = 21;

            //Main Stats
            hero.Str = 6;
            hero.Int = 0;
            hero.Dex = 3;
            hero.Luck = 2;
            hero.Speed = 3;
            hero.Defense = 3;
            hero.Resistance = 1;

            //init Power and Evade
            hero.Power = 0;
            hero.Evade = 0;

            hero.Will = 0;
            hero.Experience = 0;
            hero.Level = 1;
            hero.SkillPoint = 0;
            hero.Gold = 0;
            //hero.Resistance = 6;
            //hero.Speed = 4;


            // Order is HP, Stam, Mana, Str, Int, Dex, Speed, Luck, Def, Resist, Will
            hero.HPGrowth = 80;
            hero.MPGrowth = 65;
            hero.StamGrowth = 65;
            hero.StrGrowth = 65;
            hero.IntGrowth = 25;
            hero.DexGrowth = 45;
            hero.SpeedGrowth = 40;
            hero.LuckGrowth = 35;
            hero.DefGrowth = 55;
            hero.ResGrowth = 35;
            hero.WillGrowth = 0;
            //    65, 25, 45, 40, 35, 55, 35};
            /*
            hero.HPGrowth = 75;
            hero.StrGrowth = 50;
            hero.IntGrowth = 85;
            hero.LuckGrowth = 65;
            hero.SpGrowth = 55;
            hero.DexGrowth = 55;
            hero.DefGrowth = 35;
            hero.ResGrowth = 70;
            */
            /*do
            {
                Console.WriteLine("Please enter an initial character age between 10 and 17.");
                hero.Age = int.Parse(Console.ReadLine());
                switch (hero.Age)
                {
                    case 10:
                        hero.isCorrectAge = true;
                        break;
                    case 11:
                        hero.SkillPoint = hero.SkillPoint + 1;
                        hero.isCorrectAge = true;
                        break;
                    case 12:
                        hero.SkillPoint = hero.SkillPoint + 2;
                        hero.isCorrectAge = true;
                        break;
                    case 13:
                        hero.SkillPoint = hero.SkillPoint + 3;
                        hero.isCorrectAge = true;
                        break;
                    case 14:
                        hero.SkillPoint = hero.SkillPoint + 4;
                        hero.isCorrectAge = true;
                        break;
                    case 15:
                        hero.SkillPoint = hero.SkillPoint + 5;
                        hero.isCorrectAge = true;
                        break;
                    case 16:
                        hero.SkillPoint = hero.SkillPoint + 6;
                        hero.isCorrectAge = true;
                        break;
                    case 17:
                        hero.SkillPoint = hero.SkillPoint + 7;
                        hero.isCorrectAge = true;
                        break;
                    default:
                        hero.isCorrectAge = false;
                        Console.WriteLine("Incorrect Age");
                        hero.Age = int.Parse(Console.ReadLine());
                        break;
                }
            }*/
            //            while (hero.isCorrectAge == false);
            //            while (hero.Identifier == null || hero.Identifier == "" ||
            //                hero.Identifier == " ")
            //            {
            //                Console.WriteLine("What is your Hero's name?");
            //                hero.Identifier = Console.ReadLine();
            //            }
            Console.WriteLine("Please enter character name.");
            hero.Identifier = Console.ReadLine();
            hero.isAlive = true;
        }
        public bool CheckItems(string item)
        {
            if (items.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
