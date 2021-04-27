using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
	// Leaf
	public class InputFormMessage : IMessage
	{
		public string Name { get; set; }

		public InputFormMessage(string name)
		{
			Name = name;
		}

		public void ShowMessages(int level)
		{
			Console.WriteLine(new string('-', level) + Name);
		}
	}
}
