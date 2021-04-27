using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
	public abstract class IceCream
	{
		private double Price = 5;
		private string Flavor = "Abstract flavor";

		public virtual double GetPrice
		{
			get { return Price; }
		}

		public virtual string GetFlavor
		{
			get { return Flavor; }
		}

	}
}
