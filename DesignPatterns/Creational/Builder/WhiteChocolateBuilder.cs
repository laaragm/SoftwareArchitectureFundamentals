using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
	public class WhiteChocolateBuilder : ChocolateBuilder
	{
		private Chocolate Chocolate { get; set; } = new Chocolate();

		public override void BuildIngredients()
		{
			Chocolate.Ingredients.Add("Sweetener");
			Chocolate.Ingredients.Add("Cacao butter");
			Chocolate.Ingredients.Add("Dry milk powder");
			Chocolate.Ingredients.Add("Vanilla");
		}

		public override void BuildName() => Chocolate.Name = "White Chocolate";

		public override Chocolate GetResult() => Chocolate;
		
	}
}
