using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
	public class ExecutionAdapter
	{
		public static void Run()
		{
			var paymentStandardLog = new TransactionService(new Logger());
			paymentStandardLog.MakeTransaction();

			var paymentCustomLog = new TransactionService(new LogAdapter(new LogNetMasterService()));
			paymentCustomLog.MakeTransaction();
		}
	}
}
