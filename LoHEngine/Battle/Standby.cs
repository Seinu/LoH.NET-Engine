using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters;

namespace LoHEngine.Battle
{
    class Standby
    {
        string userspellchoice;
        string userchoice;
        string monsterchoice;
        string monsterspellchoice;
        int targetmonster;
        bool amonsterleft;
        int TotalExp;
        public Standby(List<BaseCharacter> party, List<BaseCharacter> monsters)
        {

            foreach (BaseCharacter pmember in party)
            {
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
            //BattleLoop(hero, monsters);
        }
    }
}
