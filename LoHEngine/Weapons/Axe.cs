using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Weapons
{
    class IronAxe : BaseWeapon
    {
        public IronAxe()
        {
            base.Name = "Iron Axe";
            base.Type = "Axe";
            base.WeaponPower = 8;
            base.WeaponAccuracy = 75;
            base.WeaponCrit = 0;
            base.WeaponElement = "None";
            base.WeaponEffect = "None";
        }
    }
    class SteelAxe : BaseWeapon
    {
        public SteelAxe()
        {
            base.Name = "Steel Axe";
            base.Type = "Axe";
            base.WeaponPower = 11;
            base.WeaponAccuracy = 65;
            base.WeaponCrit = 0;
            base.WeaponElement = "None";
            base.WeaponEffect = "None";
        }
    }
    class SilverAxe : BaseWeapon
    {
        public SilverAxe()
        {
            base.Name = "Silver Axe";
            base.Type = "Axe";
            base.WeaponPower = 15;
            base.WeaponAccuracy = 70;
            base.WeaponCrit = 0;
            base.WeaponElement = "None";
            base.WeaponEffect = "None";
        }
    }
    class WolfBeil : BaseWeapon
    {
        public WolfBeil()
        {
            base.Name = "Wolf Beil";
            base.Type = "Axe";
            base.WeaponPower = 10;
            base.WeaponAccuracy = 75;
            base.WeaponCrit = 5;
            base.WeaponElement = "None";
            base.WeaponEffect = "None";
        }
    }
}
