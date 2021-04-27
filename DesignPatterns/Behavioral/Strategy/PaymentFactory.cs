using DesignPatterns.Structural.Facade.CrossCutting;
using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
	public class PaymentFactory
	{
		// In this case it would be better using a Service Locator or injecting all instances in order to return only one
		public static IPayment CreatePayment(PaymentMethod paymentMethod)
		{
			switch (paymentMethod)
			{
				case PaymentMethod.CreditCard:
					return new PaymentCreditCardService
						(
							new PaymentCreditCardFacade
							(
								new PaypalGateway(), new ConfigurationManager()
							)
						);
				case PaymentMethod.Ticket:
					return new TicketPaymentService(new TicketPaymentFacade());
				case PaymentMethod.BankTransaction:
					return new BankTransactionPaymentService(new BankTransactionPaymentFacade());
				default:
					throw new ApplicationException("Payment method not recognized");
			}
		}
	}
}
