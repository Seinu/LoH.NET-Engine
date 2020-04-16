using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Characters.Enemies
{
    class Enemy : BaseCharacter
    {
        public static void init(Enemy enemy)
        {
            enemy.Name = "Enemy";
            enemy.Class = "";
            enemy.MaxHP = 0;
            enemy.CurrHP = 0;
            enemy.MaxMP = 0;
            enemy.CurrMP = 0;
            enemy.MaxSP = 0;
            enemy.CurrSP = 0;

            enemy.Str = 0;
            enemy.Int = 0;
            enemy.Dex = 0;
            enemy.Speed = 0;
            enemy.Luck = 0;
            enemy.Defense = 0;
            enemy.Resistance = 0;

            enemy.EquipWeapon = new Weapons.Dummy();

            enemy.Will = 0;

            enemy.IsAlive = true;

            enemy.EXP = 0;

            enemy.LVL = 0;

            enemy.Gold = 0;

            enemy.SkillPoint = 0;

            enemy.GoldDrop = new int[] { 0, 0 };

            enemy.fled = false;

            enemy.defending = false;

            enemy.GrowthHP = 0;
            enemy.GrowthMP = 0;
            enemy.GrowthSP = 0;
            enemy.GrowthStr = 0;
            enemy.GrowthInt = 0;
            enemy.GrowthDex = 0;
            enemy.GrowthSpeed = 0;
            enemy.GrowthLuck = 0;
            enemy.GrowthDefense = 0;
            enemy.GrowthResistance = 0;
        }
    }
}
