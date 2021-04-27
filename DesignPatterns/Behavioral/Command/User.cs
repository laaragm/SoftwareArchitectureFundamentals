using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
	// Client
	public class User
	{
		private readonly Calculator Calculator = new Calculator();
		private readonly IList<Commander> Commands = new List<Commander>();
		private int Total;

		public void Add(char op, int value)
		{
			Commander command = new CalculatorCommand(op, value, Calculator);
			command.Run();
			Commands.Add(command);
			Total++;
		}

		public void ReturnOperation(int levels)
		{
			Console.WriteLine($"Returning {levels} levels");
			for (var i = 0; i < levels; i++)
			{
				if (Total >= Commands.Count() - 1)
					continue;
				var command = Commands[Total++];
				command.Run();
			}
		}

		public void UndoOperation(int levels)
		{
			Console.WriteLine($"Undoing {levels} levels");
			for (var i = 0; i < levels; i++)
			{
				if (Total <= 0)
					continue;
				var command = Commands[--Total];
				command.UndoOperation();
			}
		}
	}
}
