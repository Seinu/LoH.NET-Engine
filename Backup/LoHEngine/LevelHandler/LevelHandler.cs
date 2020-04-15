using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters.PlayerChars;

namespace LoHEngine.LevelHandler
{
    class LevelHandler
    {
        Random rand;
        int EP_L;
        bool IslvlUp, lvlUp;

        protected int ExpCalculater(int lvlMultiplier)
        {
            int temp1, temp2;
            temp1 = 4 * lvlMultiplier - 51;
            temp2 = lvlMultiplier * temp1 + 267;
            EP_L = lvlMultiplier * temp2 - 302;
            return EP_L;
        }

        protected void lvlupProc(Hero hero)
        {
            //refactor into an array loop
            // Order is HP, Stam, Mana, Str, Int, Dex, Speed, Luck, Def, Resist, Will
            int rng = rand.Next(101);
            if (rng < hero.HPGrowth)
            {
                hero.MaxHealth++;
            }
            rng = rand.Next(101);
            if (rng < hero.MPGrowth)
            {
                hero.MaxMana++;
            }
            rng = rand.Next(101);
            if (rng < hero.StamGrowth)
            {
                hero.MaxStamina++;
            }
            rng = rand.Next(101);
            if (rng < hero.StrGrowth)
            {
                hero.Str++;
            }
            rng = rand.Next(101);
            if (rng < hero.IntGrowth)
            {
                hero.Int++;
            }
            rng = rand.Next(101);
            if (rng < hero.DexGrowth)
            {
                hero.Dex++;
            }
            rng = rand.Next(101);
            if (rng < hero.SpeedGrowth)
            {
                hero.Speed++;
            }
            rng = rand.Next(101);
            if (rng < hero.LuckGrowth)
            {
                hero.Luck++;
            }
            rng = rand.Next(101);
            if (rng < hero.DefGrowth)
            {
                hero.Defense++;
            }
            rng = rand.Next(101);
            if (rng < hero.ResGrowth)
            {
                hero.Resistance++;
            }




            /*
            hero.MaxHealth++;
            hero.MaxMana = hero.MaxMana + 0.25;
            hero.MaxStamina = hero.MaxStamina + 0.5;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0;
            hero.Dex = hero.Dex + 0.5;
            hero.Will = hero.Will + 0.75;
            hero.Luck = hero.Luck + 0.75;*/
        }
        /*
        protected void lvl10Proc(Hero hero)
        {
            hero.MaxHealth++;
            hero.MaxMana = hero.MaxMana + 0.25;
            hero.MaxStamina = hero.MaxStamina + 0.5;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0;
            hero.Dex = hero.Dex + 0.5;
            hero.Will = hero.Will + 0.75;
            hero.Luck = hero.Luck + 0.75;
        }

        protected void lvl11Proc(Hero hero)
        {
            hero.MaxHealth++;
            hero.MaxMana = hero.MaxMana + 0.25;
            hero.MaxStamina = hero.MaxStamina + 0.5;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0;
            hero.Dex = hero.Dex + 0.75;
            hero.Will = hero.Will + 0.75;
            hero.Luck = hero.Luck + 0.5;
        }

        protected void lvl12Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.75;
            hero.MaxMana = hero.MaxMana + 0.25;
            hero.MaxStamina = hero.MaxStamina + 0.75;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0;
            hero.Dex = hero.Dex + 0.75;
            hero.Will = hero.Will + 0.75;
            hero.Luck = hero.Luck + 0.5;
        }

        protected void lvl13Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.75;
            hero.MaxMana = hero.MaxMana + 0.5;
            hero.MaxStamina = hero.MaxStamina + 0.75;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0.25;
            hero.Dex = hero.Dex + 0.75;
            hero.Will = hero.Will + 0.75;
            hero.Luck = hero.Luck + 0.25;
        }

        protected void lvl14Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.75;
            hero.MaxMana = hero.MaxMana + 0.5;
            hero.MaxStamina = hero.MaxStamina + 0.75;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0.25;
            hero.Dex = hero.Dex + 0.5;
            hero.Will = hero.Will + 0.5;
            hero.Luck = hero.Luck + 0.25;
        }

        protected void lvl15Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.75;
            hero.MaxMana = hero.MaxMana + 0.5;
            hero.MaxStamina = hero.MaxStamina + 0.75;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0.5;
            hero.Dex = hero.Dex + 0.25;
            hero.Will = hero.Will + 0.5;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl16Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.5;
            hero.MaxMana = hero.MaxMana + 0.75;
            hero.MaxStamina = hero.MaxStamina + 0.75;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0.5;
            hero.Dex = hero.Dex + 0.25;
            hero.Will = hero.Will + 0.5;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl17Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.5;
            hero.MaxMana = hero.MaxMana + 0.75;
            hero.MaxStamina = hero.MaxStamina + 0.75;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0.75;
            hero.Dex = hero.Dex + 0;
            hero.Will = hero.Will + 0.25;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl18Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.5;
            hero.MaxMana = hero.MaxMana + 0.75;
            hero.MaxStamina = hero.MaxStamina + 0.75;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0.75;
            hero.Dex = hero.Dex + 0;
            hero.Will = hero.Will + 0.25;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl19Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.5;
            hero.MaxMana = hero.MaxMana + 0.75;
            hero.MaxStamina = hero.MaxStamina + 0.75;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 0.75;
            hero.Dex = hero.Dex + 0;
            hero.Will = hero.Will + 0.25;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl20Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.25;
            hero.MaxMana = hero.MaxMana + 0.5;
            hero.MaxStamina = hero.MaxStamina + 0.5;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 1;
            hero.Dex = hero.Dex + 0.5;
            hero.Will = hero.Will + 0.25;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl21Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.25;
            hero.MaxMana = hero.MaxMana + 0.5;
            hero.MaxStamina = hero.MaxStamina + 0.5;
            hero.Str = hero.Str + 0.5;
            hero.Int = hero.Int + 1;
            hero.Dex = hero.Dex + 0.5;
            hero.Will = hero.Will + 0.25;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl22Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.25;
            hero.MaxMana = hero.MaxMana + 0.25;
            hero.MaxStamina = hero.MaxStamina + 0.25;
            hero.Str = hero.Str + 0.25;
            hero.Int = hero.Int + 0.75;
            hero.Dex = hero.Dex + 0.75;
            hero.Will = hero.Will + 0.25;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl23Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0.25;
            hero.MaxMana = hero.MaxMana + 0.25;
            hero.MaxStamina = hero.MaxStamina + 0.25;
            hero.Str = hero.Str + 0.25;
            hero.Int = hero.Int + 0.5;
            hero.Dex = hero.Dex + 0.5;
            hero.Will = hero.Will + 0.25;
            hero.Luck = hero.Luck + 0;
        }

        protected void lvl24Proc(Hero hero)
        {
            hero.MaxHealth = hero.MaxHealth + 0;
            hero.MaxMana = hero.MaxMana + 0.25;
            hero.MaxStamina = hero.MaxStamina + 0.25;
            hero.Str = hero.Str + 0.25;
            hero.Int = hero.Int + 0.25;
            hero.Dex = hero.Dex + 0.25;
            hero.Will = hero.Will + 0.25;
            hero.Luck = hero.Luck + 0;
        }*/

        public bool LevelUp(Hero hero)
        {
            /*LvlMultiplier = hero.Level + 1;
            temp1 = 4 * LvlMultiplier - 51;
            temp2 = LvlMultiplier * temp1 + 267;
            EP_L = LvlMultiplier * temp2 - 302;*/

            do
            {
                EP_L = ExpCalculater(hero.Level + 1);
                if (hero.Experience >= EP_L)
                {
                    hero.Level++;
                    hero.SkillPoint++;
                    lvlupProc(hero);
                    /*switch (hero.Age)
                    {
                        case 10:
                            lvl10Proc(hero);
                            break;
                        case 11:
                            lvl11Proc(hero);
                            break;
                        case 12:
                            lvl12Proc(hero);
                            break;
                        case 13:
                            lvl13Proc(hero);
                            break;
                        case 14:
                            lvl14Proc(hero);
                            break;
                        case 15:
                            lvl15Proc(hero);
                            break;
                        case 16:
                            lvl16Proc(hero);
                            break;
                        case 17:
                            lvl17Proc(hero);
                            break;
                        case 18:
                            lvl18Proc(hero);
                            break;
                        case 19:
                            lvl19Proc(hero);
                            break;
                        case 20:
                            lvl20Proc(hero);
                            break;
                        case 21:
                            lvl21Proc(hero);
                            break;
                        case 22:
                            lvl22Proc(hero);
                            break;
                        case 23:
                            lvl23Proc(hero);
                            break;
                        case 24:
                            lvl24Proc(hero);
                            break;
                    }*/
                    lvlUp = true;
                    IslvlUp = true;
                }
                else if (hero.Experience < EP_L)
                {
                    lvlUp = false;
                }
                else
                {
                    Console.WriteLine("there was an error processing level ups");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (lvlUp == true);
            return IslvlUp;
        }
    }
}
