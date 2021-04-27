using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
	public class StandardIceCream : IceCream
	{
		private double Price = 5;
		private string Flavor = "Standard ice cream";

		public override double GetPrice
		{
			get { return Price; }
		}

		public override string GetFlavor
		{
			get { return Flavor; }
		}

	}
}
