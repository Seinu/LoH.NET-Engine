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
        List<Character> Monster;
        DataHandler data = new DataHandler();
        Hero hero;
        LoHEngine.Battle.Battle battle;
        string answer;
        Random rand;
        LoHEngine.LevelHandler.LevelHandler lvlhandler = new LoHEngine.LevelHandler.LevelHandler();
        bool DidLvl;
        GM gmcp;

        public MainGame()
        {
            Console.WriteLine("Welcome to the arena!");
            hero = new Hero();
            Hero.Initialize(hero);
            //Heroes = new List<Hero>();
            Monster = new List<Character>();
            BasicGameLoop();
        }
        void BasicGameLoop()
        {
            rand = new Random();
            gmcp = new GM();
            do
            {
                Console.Clear();
                if (hero.isGM == true)
                {
                    Console.Write(@"
What would you like to do?
_____________________________
(F)ight
(S)tore
(I)nn
(V)iew
(G)ame (M)aster Control Panel
(L)oad
s(A)ve
(Q)uit
_____________________________
F,S,I,V, GM,L,A or Q?");
                }
                else
                {
                    Console.Write(@"
What would you like to do?
_____________________________
(F)ight
(S)tore
(I)nn
(V)iew
(L)oad
s(A)ve
(Q)uit
_____________________________
F,S,I,V,L,A or Q?");
                }
                Console.WriteLine();
                answer = Console.ReadLine();
                Console.WriteLine();
                switch (answer)
                {
                    case "L":
                    case "l":
                        data.Load(hero);
                        break;
                    case "A":
                    case "a":
                        data.Save(hero);
                        break;
                    case "S":
                    case "s":
                        Store store = new Store(hero);
                        break;
                    case "I":
                    case "i":
                        Inn.Sleep(hero);
                        break;
                    case "v":
                    case "V":
                        View.PrintStats(hero);
                        break;
                    case "gm":
                    case "gM":
                    case "Gm":
                    case "GM":
                        Console.Clear();
                        if (hero.isGM == true)
                        {
                            Console.WriteLine("Welcome to the Game Master Control Panel");
                            gmcp.ControlPanel(hero);
                            break;
                        }
                        else if (hero.isGM == false)
                        {
                            break;
                        }
                        break;
                    case "F":
                    case "f":
                        string done = "";
                        do
                        {
                            Console.Clear();
                            Console.Write(@"
Which monster do you want to fight?
(S)pider:
(B)arbarian:
(M)age:
_________________________");

                            Console.WriteLine();
                            string choice = Console.ReadLine();

                            if (choice == "S" || choice == "s")
                            {
                                Monster.Add(new Spider());
                            }

                            else if (choice == "B" || choice == "b")
                            {
                                Monster.Add(new Barbarian());
                            }

                            else if (choice == "M" || choice == "m")
                            {
                                Monster.Add(new Mage());
                            }

                            else
                            {
                                Monster.Add(new Spider());
                            }
                            Console.WriteLine("Would you like to fight more monsters?");
                            Console.WriteLine();
                            done = Console.ReadLine();
                        }
                        while (done == "Y" || done == "y");
                        battle = new LoHEngine.Battle.Battle(hero, Monster);

                        if (hero.CurrentHealth < 0.01)
                        {
                            Console.WriteLine("Your game is over!");
                            continue;
                        }
                        else if (hero.fled == false)
                        {
                            int gold = 0;
                            int experience = 0;
                            foreach (Character monster in Monster)
                            {
                                if (monster.fled == false)
                                {
                                    experience += monster.Experience;
                                    gold += rand.Next(monster.GoldDropMin, monster.GoldDropMax);
                                }
                            }
                            hero.Experience += experience;
                            hero.Gold += gold;
                            DidLvl = lvlhandler.LevelUp(hero);
                            if (DidLvl == true)
                            {
                                Console.WriteLine("{0} is now level {1} and gets {2} gold and {3} experience"
                                    , hero.Identifier, hero.Level, gold, experience);
                            }
                            else
                            {
                                Console.WriteLine("{0} gets {1} gold and {2} experience"
                                    , hero.Identifier, gold, experience);
                            }
                            Monster.Clear();
                            Console.WriteLine("Press enter to continue....");
                            Console.ReadLine();
                        }
                        else
                        {
                            hero.fled = false;
                        }
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Goodbye {0}", hero.Identifier);
                        break;
                }
            }
            while (answer != "Q" && answer != "q");
        }
    }
}
