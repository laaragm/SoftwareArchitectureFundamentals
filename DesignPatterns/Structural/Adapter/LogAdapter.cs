using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
	// Adapter Class: this is the class we use to create the adaptation
	public class LogAdapter : ILogger
	{
		public readonly ILogNetMaster LogNetMaster;

		public LogAdapter(ILogNetMaster logNetMaster)
		{
			LogNetMaster = logNetMaster;
		}

		public void Log(string message)
		{
			LogNetMaster.LogInfo(message);
		}

		public void LogError(Exception exception)
		{
			LogNetMaster.LogException(exception);
		}
	}
}
