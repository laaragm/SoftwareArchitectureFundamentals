using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade.Domain
{
	public class Order
	{
		public Guid ID { get; set; }
		public decimal Value { get; set; }
		public IList<Product> Products { get; set; }
	}
}
