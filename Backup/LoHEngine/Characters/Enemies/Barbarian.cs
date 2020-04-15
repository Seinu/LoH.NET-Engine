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

            base.CurrentHealth = 22;
            base.MaxHealth = 22;
            base.CurrentMana = 0;
            base.MaxMana = 0;
            base.CurrentStamina = 25;
            base.MaxStamina = 25;

            //Main Stats
            base.Str = 10;
            base.Int = 0;
            base.Dex = 3;
            base.Luck = 2;
            base.Speed = 5;
            base.Defense = 2;
            base.Resistance = 0;

            base.Experience = 80;
            base.GoldDropMin = 30;
            base.GoldDropMax = 160;
            base.Identifier = "Barbarian";
            base.isAlive = true;

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
