using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
	public class Calculator
	{
		private int CurrentValue;

		public void GetOperation(char op, int value)
		{
			switch (op)
			{
				case '+':
					CurrentValue += value;
					break;
				case '-':
					CurrentValue -= value;
					break;
				case '/':
					CurrentValue /= value;
					break;
				case '*':
					CurrentValue *= value;
					break;
			}
			Console.WriteLine("(data {1} {2}) - Current value = {0,3}", CurrentValue, op, value);
		}
	}
}
