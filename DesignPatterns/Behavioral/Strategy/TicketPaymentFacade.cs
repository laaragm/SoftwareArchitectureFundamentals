using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
	public class TicketPaymentFacade : ITicketPaymentFacade
	{
		public string GenerateTicket()
			=> new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
					.Select(x => x[new Random().Next(x.Length)]).ToArray());
	}
}
