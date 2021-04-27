using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
	public interface ILogNetMaster
	{
		void LogException(Exception exception);
		void LogInfo(string message);
	}
}
