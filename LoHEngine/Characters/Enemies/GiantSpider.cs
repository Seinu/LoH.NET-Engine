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

            base.CurrentHealth = 380;
            base.MaxHealth = 380;
            base.Defense = 7;
            base.Experience = 180;
            base.GoldDropMin = 80;
            base.GoldDropMax = 190;
            base.Identifier = "Giant Spider";
            base.isAlive = true;
            base.MinDamage = 20;
            base.MaxDamage = 30;
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
