using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
	public class ExecutionObserver
	{
		public static void Run()
		{
			var lara = new Observer("Lara");
			var dani = new Observer("Dani");
			var google = new BovespaRole("Google", NextDecimal());
			var bradesco = new BovespaRole("Bradesco", NextDecimal());
			google.Subscribe(lara);
			google.Subscribe(dani);
			bradesco.Subscribe(lara);

			Console.WriteLine("----------------------------------------");

			for (int i = 0; i < 3; i++)
			{
				google.GetValue = NextDecimal();
				bradesco.GetValue = NextDecimal();

				if (i == 1)
					google.Unsubscribe(lara);
			}
		}

		public static decimal NextDecimal()
		{
			var random = new Random();
			var number = random.Next(141421, 314160);
			return number / (decimal)100000.00;
		}
	}
}
