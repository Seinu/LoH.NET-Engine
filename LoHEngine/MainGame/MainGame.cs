using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters;
using LoHEngine.Characters.Enemies;
using LoHEngine.Characters.PlayerChars;
using LoHEngine.Data;
using LoHEngine.Locations;

namespace LoHEngine.MainGame
{
    class MainGame
    {
        List<BaseCharacter> Monster;
        List<BaseCharacter> Party;
        DataHandler data = new DataHandler();
        Xero hero;
        Battle.Battle battle;
        //Battle.Standby standby;
        string answer;
        Random rand;
        LoHEngine.LevelHandler.LevelHandler lvlhandler = new LoHEngine.LevelHandler.LevelHandler();
        bool DidLvl;
        //GM gmcp;

        public MainGame()
        {

            //Weapons.Axe Weapon = new Weapons.Axe();
            //string asdf = Weapon.Name;
            //Console.WriteLine("Welcome to the arena!");
            hero = new Xero();
            Xero.Init(hero);
            //Heroes = new List<Hero>();
            Monster = new List<BaseCharacter>();
            Party = new List<BaseCharacter>();
            Party.Add(hero);
            BasicGameLoop();

        }
        void BasicGameLoop()
        {
            rand = new Random();
            //gmcp = new GM();
            do
            {
                Console.Clear();
                /*if (hero.isGM == true)
                {
                    Console.Write(@"
What would you like to do?
_____________________________
(F)ight
(S)tore
(I)nn
(V)iew
(G)ame (M)aster Control Panel
(Q)uit
_____________________________
F,S,I,V, GM,L,A or Q?");
                }
                else
                {*/
                    Console.Write(@"
What would you like to do?
_____________________________
(F)ight
(S)tore
(I)nn
(V)iew
(Q)uit
_____________________________
F,S,I,V,L,A or Q?");
                //}
                Console.WriteLine();
                answer = Console.ReadLine();
                Console.WriteLine();
                switch (answer)
                {
                    case "S":
                    case "s":
                        Store store = new Store(hero);
                        break;
                    case "I":
                    case "i":
                        Inn.Sleep(hero, Party);
                        break;
                    case "v":
                    case "V":
                        View.PrintStats(Party);
                        break;
                    case "F":
                    case "f":
                        string done = "";
                        do
                        {
                            Console.Clear();
                            Console.Write(@"
Which monster do you want to fight?
(S)keleton:
_________________________");

                            Console.WriteLine();
                            string choice = Console.ReadLine();

                            if (choice == "S" || choice == "s")
                            {
                                Skeleton skeleton;
                                skeleton = new Skeleton();
                                Skeleton.InitMelee(skeleton);
                                Monster.Add(skeleton);
                            }

                            else if (choice == "B" || choice == "b")
                            {
                                //Monster.Add(new Barbarian());
                            }

                            else if (choice == "M" || choice == "m")
                            {
                                //Monster.Add(new Mage());
                            }

                            else
                            {
                                //Monster.Add(new Spider());
                            }
                            Console.WriteLine("Would you like to fight more monsters(y/n)?");
                            Console.WriteLine();
                            done = Console.ReadLine();
                        }
                        while (done == "Y" || done == "y");
                        //standby = new LoHEngine.Battle.Standby(Party, Monster);
                        battle = new LoHEngine.Battle.Battle(Party, Monster);
                        foreach (BaseCharacter partymember in Party)
                        {
                            if (hero.CurrHP < 0.01)
                            {
                                Console.WriteLine(hero.Name + " Has died!");
                                hero.IsAlive = false;
                                continue;
                            }
                            else if (hero.fled == false)
                            {
                                int gold = 0;
                                int experience = 0;
                                foreach (BaseCharacter monster in Monster)
                                {
                                    if (monster.fled == false)
                                    {
                                        experience += monster.EXP;
                                        gold += rand.Next(monster.GoldDrop[0], monster.GoldDrop[1]);
                                    }
                                }
                                partymember.EXP += experience;
                                hero.Gold += gold;
                                DidLvl = lvlhandler.LevelUp(partymember);
                                if (DidLvl == true)
                                {
                                    Console.WriteLine("{0} is now level {1} and gets {2} gold and {3} experience"
                                        , partymember.Name, partymember.LVL, gold, experience);
                                }
                                else
                                {
                                    Console.WriteLine("{0} gets {1} gold and {2} experience"
                                        , partymember.Name, gold, experience);
                                }
                                Monster.Clear();
                                Console.WriteLine("Press enter to continue....");
                                Console.ReadLine();
                            }
                            else
                            {
                                partymember.fled = false;
                            }

                        }
                        
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Goodbye {0}", hero.Name);
                        break;
                }
            }
            while (answer != "Q" && answer != "q");
        }
    }
}
