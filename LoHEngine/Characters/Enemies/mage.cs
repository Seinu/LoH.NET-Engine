using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Characters.Enemies
{
    class Mage : Character
    {
        public Mage()
        {
            base.AiAttack = 55;
            base.AiDefend = 65;
            base.AiSpell = 95;

            base.spellOne = 35;
            base.spellTwo = 75;


            base.CurrentHealth = 38;
            base.MaxHealth = 38;
            base.Str = 17;
            base.Int = 29;
            base.Dex = 38;
            base.Luck = 17;
            base.Experience = 80;
            base.GoldDropMin = 30;
            base.GoldDropMax = 120;
            base.Identifier = "Mage";
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

        public override string SpellAI()
        {
            if (base.CurrentHealth < (base.CurrentHealth / 2))
            {//here we're giving the mage a bit of common sense to heal
                spellOne /= 2;
                spellTwo /= 2;
            }
            string choice;
            int ainumberchoice;
            rand = new Random();
            ainumberchoice = rand.Next(1, 100);
            if (ainumberchoice < base.spellOne)
            {
                choice = "F";
            }
            else if (ainumberchoice <= base.spellTwo && ainumberchoice >= base.spellOne)
            {
                choice = "I";
            }
            else
            {
                choice = "H";
            }
            return choice;
        }
    }
}
