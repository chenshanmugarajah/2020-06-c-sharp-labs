using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {
        }

        public override string Shoot()
        {
            return $"Zing!! Shooting a {base.ToString()} - Acme";
        }
    }
}
