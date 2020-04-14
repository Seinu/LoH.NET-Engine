using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Skills
{
    class Fireball : Spell
    {
        Random rand;

        public Fireball()
        {
            base.identifier = "Fireball";
            base.multipleHits = true;
        }
        public override int SpellCast(Character Caster)
        {
            rand = new Random();
            if (Caster.isGM == true)
            {
                Console.WriteLine("GM please enter skill rank.");
                Rank = Console.ReadLine();
                switch (Rank)
                {

                    case "1":
                        base.maxpower = 21;
                        base.minpower = 12;
                        base.magicCost = 5;
                        break;
                    case "2":
                        base.minpower = 15;
                        base.maxpower = 27;
                        base.magicCost = 7;
                        break;
                    case "3":
                        base.maxpower = 32;
                        base.minpower = 17;
                        base.magicCost = 9;
                        break;
                    case "4":
                        base.minpower = 19;
                        base.maxpower = 37;
                        base.magicCost = 11;
                        break;
                    case "5":
                        base.maxpower = 41;
                        base.minpower = 22;
                        base.magicCost = 15;
                        break;
                }
            }
            else
            {
                base.minpower = 12;
                base.maxpower = 21;
                base.magicCost = 5;
            }
            Console.WriteLine("{0} casts fireball,", Caster.Identifier);
            power = rand.Next(base.minpower, base.maxpower);
            Console.WriteLine("and hits for {0}hp of fire damage", power);
            return power;

        }
    }

}
