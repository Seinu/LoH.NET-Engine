using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters;
using LoHEngine.Skills;

namespace LoHEngine.Battle
{
    /// <summary>
    /// A collection of static methods used in our battle loop
    /// </summary>
    class BattleHelper
    {
        static int damage;
        static Random rand;

        #region CheckHealth
        /// <summary>
        /// This method should be called for each character to determine if they are alive
        /// A dead character should not be allowed to do any actions       
        /// </summary>
        /// <param name="health"> the characters current health int</param>
        /// <returns>Returns if the character is alive</returns>
        public static bool CheckHealth(double health)
        {
            bool alive;
            if (health > 0)
            {
                alive = true;
            }
            else
            {
                alive = false;

            }
            return alive;
        }
        #endregion

        #region DealDamage
        /// <summary>
        /// This method calculates the damage based on the attackers attack power
        /// vs the defenders defence stat
        /// </summary>
        /// <param name="attacker">The attacking character</param>
        /// <param name="defender">The defending character</param>
        /// <returns></returns>
        public static int DealDamage(BaseCharacter attacker, BaseCharacter defender)
        {
            rand = new Random();
            damage = rand.Next(attacker.MinDamage, attacker.MaxDamage);
            damage = (int)(damage - defender.Defense);
            if (damage < 0)
            {
                damage = 0;
            }
            if (defender.defending == true)
            {
                damage = damage / 2;
            }
            return damage;
        }
        #endregion

        #region ProcessChoice
        /// <summary>
        /// This method is used to take the choice and determine the right action for it
        /// </summary>
        /// <param name="choice"> the attackers choice</param>
        /// <param name="attacker">The active character</param>
        /// <param name="defender">The target character the attacker is attacking</param>
        public static void ProcessChoice(string choice, BaseCharacter attacker, BaseCharacter defender, string spellchoice, List<BaseCharacter> Monster, List<BaseCharacter> Party)
        {
            switch (choice)
            {
                case "A":
                case "a":
                    Console.WriteLine();
                    Console.WriteLine("{0} attacks!", attacker.Name);
                    DealDamage(attacker, defender);
                    defender.CurrHP -= damage;
                    Console.WriteLine("{0} hits the {1} for {2}hp of damage"
                        , attacker.Name, defender.Name, damage);
                    break;
                case "D":
                case "d":
                    Console.WriteLine();
                    Console.WriteLine("{0} defends!", attacker.Name);
                    break;
                case "F":
                case "f":
                    Console.WriteLine();
                    Console.WriteLine("{0} flees!", attacker.Name);
                    attacker.fled = true;
                    attacker.IsAlive = false;
                    break;
                case "S":
                case "s":
                    Console.WriteLine();
                    //CastSpell(attacker, defender, spellchoice, Monster);
                    break;
                default:
                    Console.WriteLine("I'm sorry, I didn't recognize that.");
                    Console.WriteLine();
                    choice = PrintChoice();
                    Console.WriteLine();
                    ProcessChoice(choice, attacker, defender, spellchoice, Monster, Party);
                    break;
            }
        }
        #endregion

        #region PrintStatus
        /// <summary>
        /// This method is used to print the status of both characters
        /// </summary>
        /// <param name="hero">Our hero character</param>
        /// <param name="monster">the monster character</param>
        public static void PrintStatus(BaseCharacter pmember)
        {
            //foreach (BaseCharacter pmember in Party)
            //{
                Console.Write(@"
**********************************************
        Health/Max Health
{0}:       {1}/{2} Health
**********************************************
", pmember.Name, pmember.CurrHP, pmember.MaxHP);
            //}
        }
        #endregion

        #region PrintChoice
        /// <summary>
        /// This method prints our choices and gets the choice.
        /// </summary>
        /// <returns>returns the string of the hero's choice</returns>
        public static string PrintChoice()
        {
            string choice;
            Console.WriteLine();
            Console.Write(@"
_____________________
Please choose an action:
(A)ttack:
(D)efend:
(S)pell: Broken
(F)lee:
_____________________");
            Console.WriteLine();
            choice = Console.ReadLine();
            return choice;
        }
        #endregion

        #region CheckDefence
        /// <summary>
        /// This method should be called for each active character.  This sets
        /// the bools defending and increase attack for the character.
        /// This method should be called prior to any processchoice.
        /// </summary>
        /// <param name="choice">input the string choice to check for defence</param>
        /// <param name="attacker">input the active character we are checking</param>
        public static void CheckDefence(string choice, BaseCharacter attacker)
        {
            if (attacker.defending == true)
            {
                //attacker.increaseAttack = true;
            }

            else
            {
                //attacker.increaseAttack = false;
            }
            if (choice == "D" || choice == "d")
            {
                attacker.defending = true;
            }
            else
            {
                attacker.defending = false;
            }
        }
        #endregion

        #region CastSpell
        /// <summary>
        /// Here we going to "cast" the spell
        /// </summary>
        /// <param name="attacker">The attacker</param>
        /// <param name="defender">The defender</param>
        /// <param name="spell">The spell they've chosen to cast</param>
        public static void CastSpell(Character attacker, Character defender, string spellchoice, List<Character> Monster)
        {
            Spell spell;
            spell = ProcessSpellChoice(spellchoice, attacker);
            int spellpower = spell.SpellCast(attacker);
            if (spell.isOnSelf == true)
            {
                attacker.CurrentHealth += spellpower;
                if (attacker.CurrentHealth > attacker.MaxHealth)
                {
                    attacker.CurrentHealth = attacker.MaxHealth;
                }
            }
            else if (spell.multipleHits == true)
            {
                //defender.CurrentHealth -= spellpower;
                foreach (Character monster in Monster)
                {
                    if (monster.isAlive)
                    {
                        monster.CurrentHealth = monster.CurrentHealth - spellpower;
                    }
                }
            }
            else if (spell.singleTarget == true)
            {
                defender.CurrentHealth -= spellpower;
            }
        }
        #endregion

        #region PrintSpells
        /// <summary>
        /// A method to print out the spells to choose from
        /// </summary>
        /// <returns>A string of the spell choice</returns>
        public static string PrintSpells()
        {
            Console.WriteLine();
            string spellchoice;
            Console.Write(@"
Please choose a spell:
***********************
(H)eal
(F)ireball
(I)cebolt
***********************");
            Console.WriteLine();
            spellchoice = Console.ReadLine();
            return spellchoice;
        }
        #endregion

        #region ProcessSpellChoice
        /// <summary>
        /// A method to determine which spell should be cast
        /// </summary>
        /// <param name="spellchoice">The spellchoice</param>
        /// <param name="attacker">the attacker</param>
        /// <param name="defender">the defender</param>
        public static Spell ProcessSpellChoice(string spellchoice, Character attacker)
        {
            Spell spell;
            switch (spellchoice)
            {
                case "H":
                case "h":
                    Heal heal = new Heal();
                    return heal;
                case "F":
                case "f":
                    Fireball fireball = new Fireball();
                    return fireball;
                case "I":
                case "i":
                    Icebolt icebolt = new Icebolt();
                    return icebolt;
                default:
                    Console.WriteLine();
                    Console.WriteLine("I'm sorry that wasn't a valid choice");
                    spellchoice = PrintSpells();
                    spell = ProcessSpellChoice(spellchoice, attacker);
                    break;
            }
            return spell;
        }
        #endregion

        #region CheckMonsters
        /// <summary>
        /// This method makes sure at least one monster is alive to continue the battle
        /// </summary>
        /// <param name="Monsters"></param>
        public static bool CheckMonsters(List<BaseCharacter> Monsters)
        {
            bool foundone = false;
            foreach (BaseCharacter monster in Monsters)
            {
                if (monster.IsAlive)
                {
                    foundone = true;

                }
            }
            if (foundone)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ChooseTarget
        /// <summary>
        /// This method will print out the current monster with an index
        /// so the attacker can choose which one to target.
        /// </summary>
        /// <param name="Monster">This is the list of monsters</param>
        /// <returns>Returns an index of the character to attack</returns>
        public static int ChooseTarget(List<BaseCharacter> Monster)
        {
            Console.WriteLine("Please choose the monster to attack");
            string choice;
            int x = 0;
            foreach (BaseCharacter monster in Monster)
            {
                x++;
                if (monster.IsAlive)
                {
                    Console.WriteLine("{0}: {1}", x, monster.Name);
                }
            }
            Console.WriteLine();
            choice = Console.ReadLine();
            //below is an example of exception
            //handling.
            try//try this stuff
            {
                x = int.Parse(choice);
            }
            catch (Exception)//if problem try this
            {
                Console.WriteLine("Invalid choice");
                x = ChooseTarget(Monster);
                x++;
            }
            finally//finally when it works do this
            {
                x -= 1;
            }
            return x;

        }
        #endregion
    }
}
