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

            rand = new Random();
            int rng = rand.Next(4);
            if (rng == 0)
            {
                base.Equip = "Fire Wand";
                base.EquipPow = 4;
            }
            if (rng == 1)
            {
                base.Equip = "Thunder Wand";
                base.EquipPow = 3;
            }
            if (rng == 2)
            {
                base.Equip = "Ice Wand";
                base.EquipPow = 2;
                base.EquipPow = 2;
            }
            if (rng == 3)
            {
                base.Equip = "Bare Hand";
                base.EquipPow = 0;
            }

            base.spellOne = 35;
            base.spellTwo = 75;

            base.CurrentHealth = 18;
            base.MaxHealth = 18;
            base.CurrentMana = 25;
            base.MaxMana = 25;
            base.CurrentStamina = 18;
            base.MaxStamina = 18;

            //Main Stats
            base.Str = 0;
            base.Int = 9;
            base.Dex = 3;
            base.Luck = 2;
            base.Speed = 3;
            base.Defense = 0;
            base.Resistance = 4;

            base.Experience = 80;
            base.GoldDropMin = 30;
            base.GoldDropMax = 120;
            base.Identifier = "Mage";
            base.isAlive = true;

            base.Power = (base.Int / 1.15) + base.EquipPow;

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