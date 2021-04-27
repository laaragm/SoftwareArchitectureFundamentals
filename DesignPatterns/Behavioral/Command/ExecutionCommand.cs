using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
	public class ExecutionCommand
	{
		public static void Run()
		{
			var user = new User();
			user.Add('+', 100);
			Console.ReadKey();
			user.Add('-', 50);
			Console.ReadKey();
			user.Add('*', 10);
			Console.ReadKey();
			user.Add('/', 2);
			Console.ReadKey();

			user.UndoOperation(4);
			Console.ReadKey();

			user.ReturnOperation(3);
		}
	}
}
