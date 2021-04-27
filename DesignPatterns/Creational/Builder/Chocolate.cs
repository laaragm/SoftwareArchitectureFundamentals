using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
	public class Chocolate
	{
		public string Name { get; set; }
		public IList<string> Ingredients { get; set; } = new List<string>();

		public void Show()
		{
			Console.WriteLine($"Name of the Chocolate: {Name}");
			Console.WriteLine(" Ingredients:");
			foreach (var ingredient in Ingredients)
				Console.WriteLine(" - " + ingredient);
			Console.WriteLine("-------------------------------------");
		}
	}
}
