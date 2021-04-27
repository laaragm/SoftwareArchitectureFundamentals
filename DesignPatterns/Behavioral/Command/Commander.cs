using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
	internal abstract class Commander
	{
		public abstract void Run();
		public abstract void UndoOperation();
	}
}
