using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
	public interface ILogger
	{
		void LogError(Exception exception);
		void Log(string message);
	}
}
