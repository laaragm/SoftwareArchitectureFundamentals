using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
	// Component
	public interface IMessage
	{
		string Name { get; }
		void ShowMessages(int level);
	}
}
