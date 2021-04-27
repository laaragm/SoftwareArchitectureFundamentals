using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
	public class IceCreamSyrup : IceCreamDecorator
	{
		double Price = 2;
		string Flavor = "Syrup";
		IceCream IceCream;

		public IceCreamSyrup(IceCream iceCream)
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
