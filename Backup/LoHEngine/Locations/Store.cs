using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters.PlayerChars;

namespace LoHEngine.Locations
{
    /// <summary>
    /// This is a very simple store with just a few items.
    /// We could alternatively make each item it's own class as opposed to a string
    /// The const keyword indicates that this string is a constant and will not change
    /// </summary>
    class Store
    {
        const string helmet = "Helmet";
        const string armor = "Armor";
        const string gauntlets = "Gauntlets";
        const string boots = "Boots";
        const string sword = "Sword";
        string choice = "";
        public Store(Hero hero)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the store!");
            StoreLoop(hero);
        }
        public void StoreLoop(Hero hero)
        {
            do
            {
                bool checkitem = false;
                Console.WriteLine("What would you like to buy?");
                Console.Write(@"
(S)word:     800  gold +7-16 Attack
(H)elmet:    580  gold   +1  Defense
(A)rmor:     3800 gold   +6  Defense
(G)auntlets  760  gold   +2  Defense
(B)oots      650  gold   +1  Defense
(D)one:
");
                Console.WriteLine();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "S":
                    case "s":
                        checkitem = hero.CheckItems(sword);
                        if (checkitem == false)
                        {
                            if (hero.Gold >= 800)
                            {
                                hero.Gold -= 800;
                                hero.items.Add(sword);
                                hero.EquipPow += 8;
                                Console.WriteLine("Thank you {0}!", hero.Identifier);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money.  Come back when ya do");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You've already got that!");
                        }
                        break;
                    case "H":
                    case "h":
                        checkitem = hero.CheckItems(helmet);
                        if (checkitem == false)
                        {
                            if (hero.Gold >= 580)
                            {
                                hero.Gold -= 580;
                                hero.items.Add(helmet);
                                hero.Defense += 1;
                                Console.WriteLine("Thank you {0}!", hero.Identifier);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money.  Come back when ya do");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You've already got that!");
                        }
                        break;
                    case "A":
                    case "a":
                        checkitem = hero.CheckItems(armor);
                        if (checkitem == false)
                        {
                            if (hero.Gold >= 3800)
                            {
                                hero.Gold -= 3800;
                                hero.items.Add(armor);
                                hero.Defense += 6;
                                Console.WriteLine("Thank you {0}!", hero.Identifier);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money.  Come back when ya do");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You've already got that!");
                        }
                        break;
                    case "G":
                    case "g":
                        checkitem = hero.CheckItems(gauntlets);
                        if (checkitem == false)
                        {
                            if (hero.Gold >= 760)
                            {
                                hero.Gold -= 760;
                                hero.items.Add(gauntlets);
                                hero.Defense += 2;
                                Console.WriteLine("Thank you {0}!", hero.Identifier);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money.  Come back when ya do");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You've already got that!");
                        }
                        break;
                    case "B":
                    case "b":
                        checkitem = hero.CheckItems(boots);
                        if (checkitem == false)
                        {
                            if (hero.Gold >= 650)
                            {
                                hero.Gold -= 650;
                                hero.items.Add(boots);
                                hero.Defense += 1;
                                Console.WriteLine("Thank you {0}!", hero.Identifier);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money.  Come back when ya do");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You've already got that!");
                        }
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Goodbye, and be careful out there!");
                        break;
                    default:
                        Console.WriteLine("I can't understand that gibberish you're sayin'");
                        break;
                }

            }
            while (choice != "d" && choice != "D");
            Console.WriteLine("Press enter to continue....");
            Console.ReadLine();
        }
    }

}
