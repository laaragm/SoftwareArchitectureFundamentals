using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
	public class MilkChocolateBuilder : ChocolateBuilder
	{
		private Chocolate Chocolate { get; set; } = new Chocolate();

		public override void BuildIngredients()
		{
			Chocolate.Ingredients.Add("Cocoa powder");
			Chocolate.Ingredients.Add("Milk powder");
			Chocolate.Ingredients.Add("Sugar");
			Chocolate.Ingredients.Add("Vanilla");
			Chocolate.Ingredients.Add("Coconut oil");
		}

		public override void BuildName() => Chocolate.Name = "Milk Chocolate";

		public override Chocolate GetResult() => Chocolate;
	}
}
