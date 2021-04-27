using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
	public class ExecutionDecorator
	{
		public static void Run()
		{
			Console.WriteLine("Standard Ice Cream");
			IceCream iceCream = new StandardIceCream();
			Console.WriteLine($"Flavor: {iceCream.GetFlavor}, Price: {iceCream.GetPrice}\n");

			Console.WriteLine("Decorated Ice Cream");
			iceCream = new IceCreamBalboaBar(iceCream);
			iceCream = new IceCreamSyrup(iceCream);
			Console.WriteLine($"Flavor: {iceCream.GetFlavor}, Price: {iceCream.GetPrice}\n");
		}
	}
}
