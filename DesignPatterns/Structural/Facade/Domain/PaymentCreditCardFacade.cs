using DesignPatterns.Structural.Facade.CrossCutting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade.Domain
{
	// The whole adaptation of the external world is here in this Facade which means this is the ONLY place of integration
	// This means that if someday you decide to use MercadoPago instead of Paypal for example, you just have to adjust this class
	public class PaymentCreditCardFacade : IPaymentCreditCardFacade
	{
		private readonly IPaypalGateway PaypalGateway;
		private readonly IConfigurationManager ConfigurationManager;

		public PaymentCreditCardFacade(IPaypalGateway paypalGateway, IConfigurationManager configurationManager)
		{
			PaypalGateway = paypalGateway;
			ConfigurationManager = configurationManager;
		}

		public bool Pay(Order order, Payment payment)
		{
			var apiKey = ConfigurationManager.GetValue("apiKey");
			var encriptionKey = ConfigurationManager.GetValue("encriptionKey");
			var serviceKey = PaypalGateway.GetPaypalServiceKey(apiKey, encriptionKey);
			var cardHashKey = PaypalGateway.GetCardHashKey(serviceKey, payment.CreditCard);
			var paymentResult = PaypalGateway.CommitTransaction(cardHashKey, order.ID.ToString(), payment.Value);

			return paymentResult;
		}
	}
}
