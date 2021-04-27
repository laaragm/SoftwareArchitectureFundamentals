using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade.Domain
{
	public class Payment
	{
		public string Status { get; set; }
		public decimal Value { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public string CreditCard { get; set; }
		public string Ticket { get; set; }
		public string TransferConfirmation { get; set; }
	}
}
