using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters;

namespace LoHEngine.Characters.PlayerChars
{
    class Dummy : BaseCharacter
    {
        public static void init(Dummy dummy)
        {
            dummy.Name = "Dummy";
            dummy.Class = "";
            dummy.MaxHP = 0;
            dummy.CurrHP = 0;
            dummy.MaxMP = 0;
            dummy.CurrMP = 0;
            dummy.MaxSP = 0;
            dummy.CurrSP = 0;

            dummy.Str = 0;
            dummy.Int = 0;
            dummy.Dex = 0;
            dummy.Speed = 0;
            dummy.Luck = 0;
            dummy.Defense = 0;
            dummy.Resistance = 0;

            dummy.EquipWeapon = new Weapons.Dummy();

            dummy.Will = 0;

            dummy.IsAlive = true;

            dummy.EXP = 0;

            dummy.LVL = 0;

            dummy.Gold = 0;

            dummy.SkillPoint = 0;

            dummy.GoldDrop = new int[] { 0, 0 };

            dummy.fled = false;

            dummy.defending = false;

            dummy.GrowthHP = 0;
            dummy.GrowthMP = 0;
            dummy.GrowthSP = 0;
            dummy.GrowthStr = 0;
            dummy.GrowthInt = 0;
            dummy.GrowthDex = 0;
            dummy.GrowthSpeed = 0;
            dummy.GrowthLuck = 0;
            dummy.GrowthDefense = 0;
            dummy.GrowthResistance = 0;
        }
    }
}
