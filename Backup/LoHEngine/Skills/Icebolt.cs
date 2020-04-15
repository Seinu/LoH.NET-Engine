using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters;

namespace LoHEngine.Skills
{
    class Icebolt : Spell
    {
        Random rand;

        public Icebolt()
        {
            rand = new Random();
            base.identifier = "Icebolt";
            base.singleTarget = true;
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
                        base.maxpower = 20;
                        base.minpower = 12;
                        base.magicCost = 2;
                        break;
                    case "2":
                        base.minpower = 15;
                        base.maxpower = 24;
                        base.magicCost = 2;
                        break;
                    case "3":
                        base.maxpower = 27;
                        base.minpower = 18;
                        base.magicCost = 3;
                        break;
                    case "4":
                        base.minpower = 21;
                        base.maxpower = 30;
                        base.magicCost = 4;
                        break;
                    case "5":
                        base.maxpower = 33;
                        base.minpower = 24;
                        base.magicCost = 5;
                        break;
                }
            }
            else
            {
                base.minpower = 12;
                base.maxpower = 20;
                base.magicCost = 2;
            }

            Console.WriteLine("{0} casts Icebolt,", Caster.Identifier);
            power = rand.Next(base.minpower, base.maxpower);
            return power;

        }
    }

}
