using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Facade.CrossCutting
{
	public class PaypalGateway : IPaypalGateway
	{
		public bool CommitTransaction(string cardHashKey, string orderId, decimal amount)
			=> new Random().Next(2) == 0;

		public string GetCardHashKey(string serviceKey, string creditCard)
			=> new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
					.Select(x => x[new Random().Next(x.Length)]).ToArray());

		public string GetPaypalServiceKey(string apiKey, string encriptionKey)
			=> new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
					.Select(x => x[new Random().Next(x.Length)]).ToArray());

	}
}
