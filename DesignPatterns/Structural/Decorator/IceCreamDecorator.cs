using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
	public class IceCreamDecorator : IceCream
	{
		double Price = 5;
		string Flavor = "Decorator Abstract flavor";

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
