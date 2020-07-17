using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Weapon : IShootable
    {
        private string _brand;
        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return $"Shooting";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
