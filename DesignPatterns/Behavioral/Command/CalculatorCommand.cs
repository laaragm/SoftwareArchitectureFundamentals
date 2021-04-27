using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
	internal class CalculatorCommand : Commander
	{
		private char Operator;
		private int Value;
		private readonly Calculator Calculator;

		public CalculatorCommand(char op, int value, Calculator calculator)
		{
			Operator = op;
			Value = value;
			Calculator = calculator;
		}

		public char SetOperator
		{
			set => Operator = value;
		}

		public int SetValue
		{
			set => Value = value;
		}

		public override void Run()
		{
			Calculator.GetOperation(Operator, Value);
		}

		public override void UndoOperation()
		{
			Calculator.GetOperation(UndoOperation(Operator), Value);
		}

		private static char UndoOperation(char op)
		{
			switch (op)
			{
				case '+':
					return '-';
				case '-':
					return '+';
				case '*':
					return '/';
				case '/':
					return '*';
				default:
					throw new ArgumentException("Unknown operator");
			}
		}
	}
}
