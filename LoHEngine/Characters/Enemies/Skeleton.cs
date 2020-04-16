using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Characters.Enemies
{
    class Skeleton : BaseCharacter
    {
        public static void InitMelee(Skeleton skeleton)
        {

            skeleton.AiAttack = 100;
            skeleton.AiDefend = 0;
            skeleton.AiSpell = 0;

            skeleton.Name = "Skeleton";
            skeleton.Class = "";
            skeleton.MaxHP = 20;
            skeleton.CurrHP = 20;
            skeleton.MaxMP = 20;
            skeleton.CurrMP = 20;
            skeleton.MaxSP = 20;
            skeleton.CurrSP = 20;

            skeleton.Str = 4;
            skeleton.Int = 0;
            skeleton.Dex = 2;
            skeleton.Speed = 3;
            skeleton.Luck = 0;
            skeleton.Defense = 3;
            skeleton.Resistance = 0;

            skeleton.EquipWeapon = new Weapons.Dummy();

            skeleton.Will = 0;

            skeleton.IsAlive = true;

            skeleton.EXP = 0;

            skeleton.LVL = 0;

            skeleton.Gold = 0;

            skeleton.SkillPoint = 0;

            skeleton.GoldDrop = new int[] { 0, 0 };

            skeleton.fled = false;

            skeleton.defending = false;

            skeleton.GrowthHP = 0;
            skeleton.GrowthMP = 0;
            skeleton.GrowthSP = 0;
            skeleton.GrowthStr = 0;
            skeleton.GrowthInt = 0;
            skeleton.GrowthDex = 0;
            skeleton.GrowthSpeed = 0;
            skeleton.GrowthLuck = 0;
            skeleton.GrowthDefense = 0;
            skeleton.GrowthResistance = 0;
        }
        public static void InitRanged(Skeleton skeleton)
        {
            skeleton.Name = "Skeleton";
            skeleton.Class = "";
            skeleton.MaxHP = 18;
            skeleton.CurrHP = 18;
            skeleton.MaxMP = 18;
            skeleton.CurrMP = 18;
            skeleton.MaxSP = 18;
            skeleton.CurrSP = 18;

            skeleton.Str = 4;
            skeleton.Int = 0;
            skeleton.Dex = 3;
            skeleton.Speed = 2;
            skeleton.Luck = 0;
            skeleton.Defense = 3;
            skeleton.Resistance = 0;

            skeleton.EquipWeapon = new Weapons.Dummy();

            skeleton.Will = 0;

            skeleton.IsAlive = true;

            skeleton.EXP = 0;

            skeleton.LVL = 0;

            skeleton.Gold = 0;

            skeleton.SkillPoint = 0;

            skeleton.GoldDrop = new int[] { 0, 0 };

            skeleton.fled = false;

            skeleton.defending = false;

            skeleton.GrowthHP = 0;
            skeleton.GrowthMP = 0;
            skeleton.GrowthSP = 0;
            skeleton.GrowthStr = 0;
            skeleton.GrowthInt = 0;
            skeleton.GrowthDex = 0;
            skeleton.GrowthSpeed = 0;
            skeleton.GrowthLuck = 0;
            skeleton.GrowthDefense = 0;
            skeleton.GrowthResistance = 0;
        }

        public override string AI()
        {
            string choice;
            int ainumberchoice;
            Random rand = new Random();
            ainumberchoice = rand.Next(1, 100);
            if (ainumberchoice < base.AiAttack)
            {
                choice = "A";
            }
            else if (ainumberchoice <= base.AiDefend && ainumberchoice >= base.AiAttack)
            {
                choice = "D";
            }
            else if (ainumberchoice < base.AiSpell && ainumberchoice > base.AiDefend)
            {
                choice = "S";
            }
            else
            {
                choice = "F";
            }
            return choice;
        }
    }
}
