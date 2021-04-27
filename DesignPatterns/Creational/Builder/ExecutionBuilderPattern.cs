using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
	/* Builder Pattern: Separate the construction of a complex object from its 
	representation so that the same construction process can create different representations */
	public static class ExecutionBuilderPattern
	{
		public static void Run()
		{
			ChocolateDirector director = new ChocolateDirector();
			ChocolateBuilder whiteChocolateBuilder = new WhiteChocolateBuilder();
			ChocolateBuilder milkChocolateBuilder = new MilkChocolateBuilder();

			director.Create(whiteChocolateBuilder);
			Chocolate whiteChocolate = whiteChocolateBuilder.GetResult();
			whiteChocolate.Show();

			director.Create(milkChocolateBuilder);
			Chocolate milkChocolate = milkChocolateBuilder.GetResult();
			milkChocolate.Show();
		}
	}
}
