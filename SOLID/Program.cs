using SOLID.LSP;
using SOLID.OCP;
using System;

namespace SOLID
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Choose a SOLID concept:");
			Console.WriteLine("1. OCP");
			Console.WriteLine("2. LSP");

			var option = Console.ReadKey();

			switch (option.KeyChar)
			{
				case '1':
					ATM.GetOperations();
					break;
				case '2':
					AreaCalculus.Calculate();
					break;
			}
		}
	}
}
