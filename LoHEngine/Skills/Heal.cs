using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Skills
{
    class Heal : Spell
    {
        public Heal()
        {
            base.identifier = "Heal";
            base.isOnSelf = true;
            base.power = 30;
            base.magicCost = 3;
        }

        public override int SpellCast(Character Caster)
        {
            Console.WriteLine("{0} casts heal,", Caster.Identifier);
            Console.WriteLine("and heals {0}hp", power);
            return power;

        }
    }
}
