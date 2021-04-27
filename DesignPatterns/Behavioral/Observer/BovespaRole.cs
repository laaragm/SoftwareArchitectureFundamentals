using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
	// Concrete Subject
	public class BovespaRole : Investment
	{
		public BovespaRole(string symbol, decimal price) : base(symbol, price)
		{
		}
	}
}
