using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
	// Strategy Pattern
	public class OrderService
	{
		private readonly IPayment Payment;

		public OrderService(IPayment payment)
		{
			Payment = payment;
		}

		// This is our generic strategy and the concrete strategies are 
		// - BankTransactionPaymentService
		// - TicketPaymentService
		// - PaymentCreditCardService
		public Payment Pay(Order order, Payment payment) => Payment.Pay(order, payment);

	}
}
