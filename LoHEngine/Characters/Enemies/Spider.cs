using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Characters.Enemies
{
    class Spider : Character
    {
        public Spider()
        {
            base.AiAttack = 90;
            base.AiDefend = 100;
            base.AiSpell = 0;

            base.Equip = "Fang";

            base.CurrentHealth = 22;
            base.MaxHealth = 22;
            base.CurrentMana = 0;
            base.MaxMana = 0;
            base.CurrentStamina = 25;
            base.MaxStamina = 25;

            //Main Stats
            base.Str = 6;
            base.Int = 0;
            base.Dex = 2;
            base.Luck = 1;
            base.Speed = 3;
            base.Defense = 1;
            base.Resistance = 0;

            base.Experience = 30;
            base.GoldDropMin = 5;
            base.GoldDropMax = 30;
            base.Identifier = "Spider";
            base.isAlive = true;

            base.CritRate = ((base.Dex + base.Speed) / 2) + base.Luck;

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
