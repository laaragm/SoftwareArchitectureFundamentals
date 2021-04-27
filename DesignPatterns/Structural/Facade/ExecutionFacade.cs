using DesignPatterns.Structural.Facade.CrossCutting;
using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
	public class ExecutionFacade
	{
		public static void Run()
		{
			var products = new List<Product>
			{
				new Product
				{
					Name = "Spotify Signature",
					Value = new Random().Next(50)
				},
				new Product
				{
					Name = "Airline ticket",
					Value = new Random().Next(3000)
				},
				new Product
				{
					Name = "IPhone",
					Value = new Random().Next(8000)
				},
			};

			var order = new Order
			{
				ID = Guid.NewGuid(),
				Products = products
			};

			var payment = new Payment
			{
				CreditCard = "3333 6666 9999 1111"
			};

			// Solve this with DI
			var paymentService = new PaymentCreditCardService(new PaymentCreditCardFacade(new PaypalGateway(), new ConfigurationManager()));
			var paymentResult = paymentService.Pay(order, payment);
			Console.WriteLine(paymentResult.Status);
		}
	}
}
