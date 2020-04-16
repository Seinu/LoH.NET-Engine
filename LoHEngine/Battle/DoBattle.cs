/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Battle
{
    class DoBattle
    {
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
                    }*//*
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
*/