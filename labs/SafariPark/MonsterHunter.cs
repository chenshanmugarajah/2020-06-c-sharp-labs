using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class MonsterHunter : Hunter
    {
        private string _weapon;
        public MonsterHunter(string fName, string lName, string camera, string weapon) : base(fName, lName, camera)
        {
            _weapon = weapon;
        }
        public sealed override string ToString()
        {
            return $"{base.ToString()} Weapon: {_weapon}";
        }
    }
}
