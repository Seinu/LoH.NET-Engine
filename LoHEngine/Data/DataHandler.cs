using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using LoHEngine.Characters.PlayerChars;

namespace LoHEngine.Data
{

    public class DataHandler
    {
        string name;
        public DataHandler()
        {

        }

        public void Save(Hero hero)
        {
            if (Directory.Exists(@".\Characters") == false)
            {
                Directory.CreateDirectory(@".\Characters");
            }
            StreamWriter file = new StreamWriter(@".\Characters\" + hero.Identifier + ".dat");
            // Order is HP, Stam, Mana, Str, Int, Dex, Speed, Luck, Def, Resist, Will
            file.WriteLine(hero.Identifier);
            file.WriteLine(hero.isGM);
            file.WriteLine(hero.CurrentHealth);
            file.WriteLine(hero.MaxHealth);
            file.WriteLine(hero.CurrentStamina);
            file.WriteLine(hero.MaxStamina);
            file.WriteLine(hero.CurrentMana);
            file.WriteLine(hero.MaxMana);

            file.WriteLine(hero.Str);
            file.WriteLine(hero.Int);
            file.WriteLine(hero.Dex);
            file.WriteLine(hero.Speed);
            file.WriteLine(hero.Luck);
            file.WriteLine(hero.Defense);
            file.WriteLine(hero.Resistance);
            file.WriteLine(hero.Will);

            file.WriteLine(hero.Experience);
            file.WriteLine(hero.Level);
            file.WriteLine(hero.Age);
            file.WriteLine(hero.SkillPoint);
            file.WriteLine(hero.Gold);

            foreach (string item in hero.items)
            {
                file.WriteLine(item);
            }

            file.Close();
            Console.WriteLine("Game Save successful");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }



        public void Load(Hero hero)
        {
            bool done = false;
            string item;
            Console.WriteLine("Please input the character name.");
            name = Console.ReadLine();
            StreamReader file = new StreamReader(@"c:\LoH\" + name + ".dat");
            hero.Identifier = file.ReadLine();
            hero.isGM = bool.Parse(file.ReadLine());
            hero.CurrentHealth = double.Parse(file.ReadLine());
            hero.MaxHealth = double.Parse(file.ReadLine());

            hero.CurrentStamina = double.Parse(file.ReadLine());
            hero.MaxStamina = double.Parse(file.ReadLine());

            hero.CurrentMana = double.Parse(file.ReadLine());
            hero.MaxMana = double.Parse(file.ReadLine());

            hero.Str = int.Parse(file.ReadLine());
            hero.Int = int.Parse(file.ReadLine());
            hero.Dex = int.Parse(file.ReadLine());
            hero.Speed = int.Parse(file.ReadLine());
            hero.Luck = int.Parse(file.ReadLine());
            hero.Defense = int.Parse(file.ReadLine());
            hero.Resistance = int.Parse(file.ReadLine());
            hero.Will = int.Parse(file.ReadLine());

            hero.Experience = int.Parse(file.ReadLine());
            hero.Level = int.Parse(file.ReadLine());
            hero.Age = int.Parse(file.ReadLine());
            hero.SkillPoint = int.Parse(file.ReadLine());
            hero.Gold = int.Parse(file.ReadLine());

            while (done == false)
            {
                item = file.ReadLine();

                if (item != null)
                {
                    hero.items.Add(item);
                }
                else
                {
                    done = true;
                }
            }
            file.Close();
            Console.WriteLine("Load Successful {0}.", hero.Identifier);
            Console.WriteLine("GM Status is set to " + hero.isGM + ".");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
