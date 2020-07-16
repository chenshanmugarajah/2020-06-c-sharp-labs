using ClassesApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
	public class Hunter : Person
	{
		public IShootable Shooter { get; set; }

		public Hunter(string fName, string lName, IShootable inputShooter) : base(fName, lName)
		{
			Shooter = inputShooter;
		}

		public string Shoot()
		{
			return $"{base.GetFullName()}: {Shooter.Shoot()}";
		}

		public override string ToString()
		{
			return $"{base.GetFullName()}: {base.ToString()} Shooter: {Shooter}";
		}
		
	}
}
