using ClassesApp;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace SafariPark
{
    public class Program
    {
        public static void Main()
        {
            Camera pentax = new Camera("Pentax");
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");

            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());

            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());

            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());

            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
        }

    }
}