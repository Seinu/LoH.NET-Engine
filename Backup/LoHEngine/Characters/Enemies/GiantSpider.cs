using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Characters.Enemies
{
    class GiantSpider : Character
    {
        public GiantSpider()
        {
            base.AiAttack = 90;
            base.AiDefend = 100;
            base.AiSpell = 0;

            rand = new Random();
            int rng = rand.Next(3);
            if (rng == 0)
            {
                base.Equip = "Fang";
                base.EquipPow = 2;
            }
            if (rng == 1)
            {
                base.Equip =  "Poison Fang";
                base.EquipPow = 4;
            }
            if (rng == 2)
            {
                base.Equip = "Sharp Fang";
                base.EquipPow = 5;
            }


            base.CurrentHealth = 30;
            base.MaxHealth = 30;
            base.CurrentMana = 0;
            base.MaxMana = 0;
            base.CurrentStamina = 35;
            base.MaxStamina = 35;

            //Main Stats
            base.Str = 12;
            base.Int = 0;
            base.Dex = 18;
            base.Luck = 5;
            base.Speed = 8;
            base.Defense = 6;
            base.Resistance = 4;

            base.CurrentHealth = 380;
            base.MaxHealth = 380;
            base.Defense = 7;
            base.Experience = 180;
            base.GoldDropMin = 80;
            base.GoldDropMax = 190;
            base.Identifier = "Giant Spider";
            base.isAlive = true;

            base.Power = base.Str + base.EquipPow;

            base.MaxDamage = (int)(base.Power / 1.5);
            base.MinDamage = (int)(base.Power / 3);
        }

        public override string AI()
        {
            string choice;
            int ainumberchoice;
            rand = new Random();
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
