using System;
using System.Linq;

namespace SOLID.OCP
{
	public class Debit
	{
		public string AccountNumber { get; set; }
		public decimal Value { get; set; }
		public string TransactionNumber { get; set; }
		
		public string FormatTransaction()
		{
			TransactionNumber = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 15)
									.Select(s => s[new Random().Next(s.Length)]).ToArray());
			return TransactionNumber;
		} 
	}
}