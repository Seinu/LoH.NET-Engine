using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters.PlayerChars;
using LoHEngine.Characters;

namespace LoHEngine.Battle
{
    class Battle
    {
        string userspellchoice;
        string userchoice;
        string monsterchoice;
        string monsterspellchoice;
        int targetmonster;
        bool amonsterleft, apmemberleft;
        int TotalExp;

        public Battle(List<BaseCharacter> party, List<BaseCharacter> monsters)
        {

            foreach (BaseCharacter pmember in party)
            {
                var weaponname = pmember.EquipWeapon.Name;
                pmember.Power = (pmember.EquipWeapon.WeaponPower + pmember.Str / 1);
                pmember.MaxDamage = (int)(pmember.Power / 1.5);
                pmember.MinDamage = (int)(pmember.Power / 3);
                pmember.CritRate = (pmember.Dex + pmember.Speed) / 2;

            }

            foreach (BaseCharacter pmember in monsters)
            {
                pmember.Power = (pmember.EquipWeapon.WeaponPower + pmember.Str / 1);
                pmember.MaxDamage = (int)(pmember.Power / 1.5);
                pmember.MinDamage = (int)(pmember.Power / 3);
                pmember.CritRate = (pmember.Dex + pmember.Speed) / 2;

            }
            Console.Clear();
            Console.WriteLine("Party: ");
            foreach (BaseCharacter pmember in party)
            {
                Console.WriteLine("{0}", pmember.Name);

            }
            Console.WriteLine("Is Facing:");
            foreach (BaseCharacter monster in monsters)
            {
                Console.WriteLine("{0}", monster.Name);
            }
            Console.ReadLine();
            Console.Clear();
            //EngageBattle(party, monsters);
            BattleLoop(party, monsters);
        }
        public void BattleLoop(List<BaseCharacter> party, List<BaseCharacter> monsters)
        {
            var asdf = party.Count;
            do
            {
                foreach (BaseCharacter pmember in party)
                {
                    if (pmember.IsAlive)
                        BattleHelper.PrintStatus(pmember);
                    else
                        Console.WriteLine(pmember + " Is Dead");
                }
                foreach (BaseCharacter monster in monsters)
                {
                    if (monster.IsAlive)
                        BattleHelper.PrintStatus(monster);
                }
                userchoice = BattleHelper.PrintChoice();

                foreach (BaseCharacter hero in party)
                {
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
                    BattleHelper.ProcessChoice(userchoice, hero, monsters[targetmonster], userspellchoice, monsters, party);
                }

                foreach (BaseCharacter monster in monsters)
                {
                    monster.IsAlive = BattleHelper.CheckHealth(monster.CurrHP);
                    if (monster.IsAlive == true)
                    {
                        monsterchoice = monster.AI();
                        BattleHelper.CheckDefence(monsterchoice, monster);
                        if (monsterchoice == "S" || monsterchoice == "s")
                        {
                            monsterspellchoice = monster.SpellAI();
                        }

                        Random rand = new Random();
                        BattleHelper.ProcessChoice(monsterchoice, monster, party[rand.Next(party.Count)], monsterspellchoice, monsters, party);
                        
                        /*
                        for (int i = 0; i < party.Count; i++)
                        {
                            Random rand = new Random();
                            if (rand.Next(101) > 50)
                            {
                                BattleHelper.ProcessChoice(monsterchoice, monster, party[i], monsterspellchoice, monsters, party);
                                break;
                            }
                        }*/
                    }
                    /*else if (monster.isAlive == false)
                    {
                        TotalExp = monster.Experience + TotalExp;
                        Console.WriteLine(TotalExp);
                    }*/
                }
                amonsterleft = BattleHelper.CheckMonsters(monsters);
                apmemberleft = BattleHelper.CheckMonsters(party);
                Console.WriteLine("Press enter to continue.....");
                Console.ReadLine();
                Console.Clear();
            }
            while (party[0].IsAlive == true && amonsterleft == true);
            foreach (BaseCharacter monster in monsters)
            {
                TotalExp = monster.EXP + TotalExp;
            }
        }
    }
}
