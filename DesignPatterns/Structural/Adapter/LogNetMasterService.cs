using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
	// Adaptee Class: this is the class we'll use to substitute the target
	public class LogNetMasterService : ILogNetMaster
	{
		public void LogException(Exception exception)
		{
			Console.WriteLine($"Custom log: {exception.Message}");
		}

		public void LogInfo(string message)
		{
			Console.WriteLine($"Custom log: {message}");
		}
	}
}
