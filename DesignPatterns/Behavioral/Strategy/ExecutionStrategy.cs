using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
	public class ExecutionStrategy
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

			var creditCardPayment = new Payment
			{
				PaymentMethod = PaymentMethod.CreditCard,
				CreditCard = "3333 6666 9999 1111"
			};

			var ticketPayment = new Payment
			{
				PaymentMethod = PaymentMethod.Ticket,
			};

			var bankTransactionPayment = new Payment
			{
				PaymentMethod = PaymentMethod.BankTransaction,
			};

			var orderWithCreditCard = new OrderService(PaymentFactory.CreatePayment(creditCardPayment.PaymentMethod));
			var paymentCreditCard = orderWithCreditCard.Pay(order, creditCardPayment);
			Console.WriteLine(paymentCreditCard.Status);

			Console.WriteLine("-------------------------------------------------------");

			var orderWithTicket = new OrderService(PaymentFactory.CreatePayment(ticketPayment.PaymentMethod));
			var paymentWithTicket = orderWithTicket.Pay(order, ticketPayment);
			Console.WriteLine(paymentWithTicket.Status);

			Console.WriteLine("-------------------------------------------------------");

			var orderBankTransaction = new OrderService(PaymentFactory.CreatePayment(bankTransactionPayment.PaymentMethod));
			var paymentBankTransaction = orderBankTransaction.Pay(order, bankTransactionPayment);
			Console.WriteLine(paymentBankTransaction.Status);
		}
	}
}
