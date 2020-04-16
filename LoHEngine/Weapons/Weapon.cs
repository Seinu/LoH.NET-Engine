using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoHEngine.Weapons
{
    public class BaseWeapon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int WeaponPower { get; set; }
        public int WeaponAccuracy { get; set; }

        public int WeaponCrit { get; set; }
        public string WeaponElement { get; set; }

        public string WeaponEffect { get; set; }

        public void Weapon()
        {}

        public void Weapon(string name, int weaponpower, int weaponcrit, string weaponelement, string weaponeffect)
        {
            Name = name;
            WeaponPower = weaponpower;
            WeaponCrit = weaponcrit;
            WeaponElement = weaponelement;
            WeaponEffect = weaponeffect;
        }

    }

}
