using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Characters.PlayerChars
{
    class Xero : BaseCharacter
    {
        public static void Init(Xero xero)
        {
            xero.Name = "Xero";
            xero.Class = "";
            xero.MaxHP = 19;
            xero.CurrHP = 19;
            xero.MaxMP = 19;
            xero.CurrMP = 19;
            xero.MaxSP = 19;
            xero.CurrSP = 19;

            xero.Str = 7;
            xero.Int = 0;
            xero.Dex = 4;
            xero.Speed = 5;
            xero.Luck = 3;
            xero.Defense = 8;
            xero.Resistance = 0;

            xero.EquipWeapon = new Weapons.WolfBeil();

            xero.Will = 0;

            xero.IsAlive = true;

            xero.EXP = 0;

            xero.LVL = 1;

            xero.Gold = 0;

            xero.SkillPoint = 0;

            xero.GoldDrop = new int[] { 0, 0 };

            xero.fled = false;

            xero.defending = false;

            xero.GrowthHP = 90;
            xero.GrowthMP = 90;
            xero.GrowthSP = 90;
            xero.GrowthStr = 60;
            xero.GrowthInt = 0;
            xero.GrowthDex = 45;
            xero.GrowthSpeed = 35;
            xero.GrowthLuck = 30;
            xero.GrowthDefense = 50;
            xero.GrowthResistance = 25;
        }
    }
}
