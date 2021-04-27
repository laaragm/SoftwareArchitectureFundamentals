using System;

namespace SOLID.LSP
{
	public class AreaCalculus
	{
		public static void Calculate()
		{
			var square = new Square(2, 2);
			var rectangle = new Rectangle(2, 5);
			GetParalelogramArea(square);
			GetParalelogramArea(rectangle);
		}

		private static void GetParalelogramArea(Paralelogram rectangle)
		{
			Console.WriteLine("\nArea calculus");
			Console.WriteLine($"{rectangle.Height} {rectangle.Width}");
			Console.WriteLine(rectangle.Area);
		}

	}
}