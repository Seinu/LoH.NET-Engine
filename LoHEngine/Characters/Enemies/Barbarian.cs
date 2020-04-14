using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Characters.Enemies
{
    class Barbarian : Character
    {
        public Barbarian()
        {
            base.AiAttack = 95;
            base.AiDefend = 101;
            base.AiSpell = 0;

            base.CurrentHealth = 55;
            base.MaxHealth = 55;
            base.CurrentMana = 28;
            base.MaxMana = 28;
            base.CurrentStamina = 43;
            base.MaxStamina = 43;
            base.Defense = 5;
            base.Str = 36;
            base.Int = 11;
            base.Dex = 23;
            base.Will = 35;
            base.Luck = 17;
            base.Experience = 80;
            base.GoldDropMin = 30;
            base.GoldDropMax = 160;
            base.Identifier = "Barbarian";
            base.isAlive = true;
            base.MaxDamage = (int)(base.Str / 1.5);
            base.MinDamage = (int)(base.Str / 3);
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
