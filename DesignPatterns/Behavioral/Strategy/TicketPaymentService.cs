using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
	public class TicketPaymentService : IPayment
	{
		private readonly ITicketPaymentFacade TicketPaymentFacade;

		public TicketPaymentService(ITicketPaymentFacade ticketPaymentFacade)
		{
			TicketPaymentFacade = ticketPaymentFacade;
		}

		public Payment Pay(Order order, Payment payment)
		{
			payment.Value = order.Products.Sum(x => x.Value);
			Console.WriteLine($"Initializing payment with ticket for value: {payment.Value} BRL");
			payment.Ticket = TicketPaymentFacade.GenerateTicket();
			payment.Status = "Waiting for payment";
			return payment;
		}
	}
}
