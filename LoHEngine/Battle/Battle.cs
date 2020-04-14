using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Battle
{
    class Battle
    {
        string userspellchoice;
        string userchoice;
        string monsterchoice;
        string monsterspellchoice;
        int targetmonster;
        bool amonsterleft;
        int TotalExp;

        public Battle(Hero hero, List<Character> monsters)
        {
            hero.Power = hero.EquipPow + (int)(hero.Str / 1);
            hero.MaxDamage = (int)(hero.Power / 1.5);
            hero.MinDamage = (int)(hero.Power / 3);
            Console.Clear();
            Console.WriteLine("{0} is facing:", hero.Identifier);
            foreach (Character monster in monsters)
            {
                Console.WriteLine("{0}", monster.Identifier);
            }
            Console.ReadLine();
            Console.Clear();
            BattleLoop(hero, monsters);
        }
        public void BattleLoop(Hero hero, List<Character> monsters)
        {
            do
            {
                BattleHelper.PrintStatus(hero);
                foreach (Character monster in monsters)
                {
                    if (monster.isAlive)
                        BattleHelper.PrintStatus(monster);
                }
                userchoice = BattleHelper.PrintChoice();

                Console.WriteLine();
                BattleHelper.CheckDefence(userchoice, hero);
                if (userchoice == "s" || userchoice == "S")
                {
                    userspellchoice = BattleHelper.PrintSpells();
                }
                else if (userchoice == "f" || userchoice == "F")
                {
                    Console.WriteLine("You have fled");
                    Console.WriteLine("Press any key to continue");
                    hero.fled = true;
                    continue;
                }
                targetmonster = BattleHelper.ChooseTarget(monsters);
                BattleHelper.ProcessChoice(userchoice, hero, monsters[targetmonster], userspellchoice, monsters);

                foreach (Character monster in monsters)
                {
                    monster.isAlive = BattleHelper.CheckHealth(monster.CurrentHealth);
                    if (monster.isAlive == true)
                    {
                        monsterchoice = monster.AI();
                        BattleHelper.CheckDefence(monsterchoice, monster);
                        if (monsterchoice == "S" || monsterchoice == "s")
                        {
                            monsterspellchoice = monster.SpellAI();
                        }

                        BattleHelper.ProcessChoice(monsterchoice, monster, hero, monsterspellchoice, monsters);
                    }
                    /*else if (monster.isAlive == false)
                    {
                        TotalExp = monster.Experience + TotalExp;
                        Console.WriteLine(TotalExp);
                    }*/
                }
                amonsterleft = BattleHelper.CheckMonsters(monsters);
                Console.WriteLine("Press enter to continue.....");
                Console.ReadLine();
                Console.Clear();
            }
            while (hero.isAlive == true && amonsterleft == true);
            foreach (Character monster in monsters)
            {
                TotalExp = monster.Experience + TotalExp;
            }
        }
    }
}
