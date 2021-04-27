using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Facade.Domain
{
	public class PaymentCreditCardService : IPayment
	{
		private readonly IPaymentCreditCardFacade PaymentCreditCardFacade;

		public PaymentCreditCardService(IPaymentCreditCardFacade paymentCreditCardFacade)
		{
			PaymentCreditCardFacade = paymentCreditCardFacade;
		}

		// We're using the Facade and because of this we didn't bring the complexity of the external
		// world (integration with Paypal in this case) to our implementation of the Payment Transaction
		public Payment Pay(Order order, Payment payment)
		{
			payment.Value = order.Products.Sum(x => x.Value);
			Console.WriteLine($"Initializing payment with credit card for value: {payment.Value} BRL");
			if (PaymentCreditCardFacade.Pay(order, payment))
			{
				payment.Status = "Paid with credit card";
				return payment;
			}
			payment.Status = "Credit card refused";
			return payment;
		}
	}
}
