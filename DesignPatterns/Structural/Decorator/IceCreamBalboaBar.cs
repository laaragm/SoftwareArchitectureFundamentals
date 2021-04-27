using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
	public class IceCreamBalboaBar : IceCreamDecorator
	{
		double Price = 7;
		string Flavor = "Balboa Bar";
		IceCream IceCream;

		public IceCreamBalboaBar(IceCream iceCream)
		{
			IceCream = iceCream;
		}

		public override double GetPrice
		{
			get { return Price + IceCream.GetPrice; }
		}
		public override string GetFlavor
		{
			get { return $"{IceCream.GetFlavor} {Flavor}"; }
		}
	}
}
