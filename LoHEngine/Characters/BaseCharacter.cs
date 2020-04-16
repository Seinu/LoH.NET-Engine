using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Characters
{
    class BaseCharacter
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public double MaxHP { get; set; }
        public double MaxMP { get; set; }
        public double MaxSP { get; set; }
        public double CurrHP { get; set; }
        public double CurrMP { get; set; }
        public double CurrSP { get; set; }

        public double Str { get; set; } //for melee attacks
        public double Int { get; set; } //for magic attacks
        public double Dex { get; set; } //aim, bow damage accuracy, etc
        public double Speed { get; set; } //speed of attacks, and manipulation of objects
        public double Luck { get; set; } //crit rate RNG luckiness with crit rate, drop rate, collect rate, etc
        public double Defense { get; set; } //defense against melee attacks
        public double Resistance { get; set; } // defense against magic attacks, also known as magic defense

        public LoHEngine.Weapons.BaseWeapon EquipWeapon { get; set; }

        //ranged attack defense = (defense + resistance) / 2

        public double Will { get; set; } //currently unused

        public bool IsAlive { get; set; }

        public int EXP { get; set; }

        public int LVL { get; set; }

        public int Gold { get; set; }

        public int SkillPoint { get; set; }

        public int[] GoldDrop { get; set; } 

        public bool fled { get; set; }

        public bool defending { get; set; }
        public double GrowthHP { get; set; }
        public double GrowthMP { get; set; }
        public double GrowthSP { get; set; }

        public double GrowthStr { get; set; } //for melee attacks
        public double GrowthInt { get; set; } //for magic attacks
        public double GrowthDex { get; set; } //aim, bow damage accuracy, etc
        public double GrowthSpeed { get; set; } //speed of attacks, and manipulation of objects
        public double GrowthLuck { get; set; } //crit rate RNG luckiness with crit rate, drop rate, collect rate, etc
        public double GrowthDefense { get; set; } //defense against melee attacks
        public double GrowthResistance { get; set; } // defense against magic attacks, also known as magic defense

        public double Evade { get; set; }
        public double Power { get; set; }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public double CritRate { get; set; }

        public int AiAttack { get; set; }
        public int AiDefend { get; set; }
        public int AiSpell { get; set; }




        //public double Evade; // Evade is a combination of Dex, Luck, and Speed and how well you can evade an attack
        //public double Power; // Power is end calculation of all damage stats

        public void Character()
        {
            defending = false;
            fled = false;
        }

        public virtual string AI()
        {
            string choice = "";
            return choice;
        }

        public virtual string SpellAI()
        {
            string choice = "";
            return choice;
        }
    }
}
