using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

    public class Hunter : Person
    {
        private string _camera;
        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            _camera = camera;
        }

        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }

        public Hunter()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }
    }
}
