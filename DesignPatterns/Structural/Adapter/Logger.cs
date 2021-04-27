using DesignPatterns.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
	// Target Class: this is the class we want to substitute through the pattern
	public class Logger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine($"Standard log: {message}");
		}

		public void LogError(Exception exception)
		{
			Console.WriteLine($"Standard log: {exception.Message}");

		}
	}
}
