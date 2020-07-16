using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {
        }

        public override string Shoot()
        {
            return $"Splash!! Shooting a {base.ToString()} - Supersoaker";
        }
    }
}
