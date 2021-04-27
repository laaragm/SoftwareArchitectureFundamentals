using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade.Domain
{
	public interface IPaymentCreditCardFacade
	{
		bool Pay(Order order, Payment payment);
	}
}
