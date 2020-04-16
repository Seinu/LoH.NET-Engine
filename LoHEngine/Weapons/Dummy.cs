using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Weapons
{
    class Dummy : BaseWeapon
    {
        public Dummy()
        {
            base.Name = "Dummy";
            base.Type = "Dummy";
            base.WeaponPower = 0;
            base.WeaponCrit = 0;
            base.WeaponElement = "None";
            base.WeaponEffect = "None";
        }
    }
}
