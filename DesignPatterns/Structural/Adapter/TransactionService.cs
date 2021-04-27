using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
	// Client
	public class TransactionService
	{
		private readonly ILogger Logger;

		public TransactionService(ILogger logger)
		{
			Logger = logger;
		}

		public void MakeTransaction()
		{
			Logger.Log("The transaction was made successfully");
		}
	}
}
