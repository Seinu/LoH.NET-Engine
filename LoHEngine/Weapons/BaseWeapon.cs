using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Weapons
{
    public class BaseWeapon
    {
        public string Identifier { get; set; }
        public int WeaponPower { get; set; }

        public int WeaponCrit { get; set; }
        public string WeaponElement { get; set; }

        public string WeaponEffect { get; set; }
    }

}
