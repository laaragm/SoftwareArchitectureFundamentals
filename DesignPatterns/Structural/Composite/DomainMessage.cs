using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
	// Leaf
	public class DomainMessage : IMessage
	{
		public string Name { get; set; }

		public DomainMessage(string name)
		{
			Name = name;
		}

		public void ShowMessages(int level)
		{
			Console.WriteLine(new string('-', level) + Name);
		}
	}
}
