using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
	public class BankTransactionPaymentService : IPayment
	{
		private readonly IBankTransactionPaymentFacade BankTransactionPaymentFacade;

		public BankTransactionPaymentService(IBankTransactionPaymentFacade bankTransactionPaymentFacade)
		{
			BankTransactionPaymentFacade = bankTransactionPaymentFacade;
		}

		public Payment Pay(Order order, Payment payment)
		{
			payment.Value = order.Products.Sum(x => x.Value);
			Console.WriteLine($"Initializing payment with bank transaction for value: {payment.Value} BRL");
			payment.Ticket = BankTransactionPaymentFacade.GenerateTransaction();
			payment.Status = "Paid via bank transaction";
			return payment;
		}
	}
}
