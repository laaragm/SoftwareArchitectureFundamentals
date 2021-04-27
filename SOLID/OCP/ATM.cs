using System;

namespace SOLID.OCP
{
	public class ATM
	{
		public static void GetOperations()
		{
			MenuOperations();

			var option = Console.ReadKey();
			var result = string.Empty;
			var debit = DebitData();

			switch (option.KeyChar)
			{
				case '1':
					Console.WriteLine("Performing operation in Account");
					result = debit.PerformDirectDebit();
					break;
				case '2':
					Console.WriteLine("Performing operation in Savings Account");
					result = debit.PerformDebitInSavingsAccount();
					break;
				case '3':
					Console.WriteLine("Performing operation in Investiment Account");
					result = debit.PerformDebitInInvestmentAccount();
					break;
			}

			TransactionResult(result);
		}

		private static void MenuOperations()
		{
			Console.Clear();
			Console.WriteLine("Choose an option:");
			Console.WriteLine();
			Console.WriteLine("1 - Withdraw account");
			Console.WriteLine("2 - Withdraw savings account");
			Console.WriteLine("3 - Withdraw investiment account");
		}

		private static Debit DebitData()
		{
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("Enter the account number:");
			var account = Console.ReadLine();
			Console.WriteLine("Enter the value:");
			var value = Convert.ToDecimal(Console.ReadLine());

			var debit = new Debit()
			{
				AccountNumber = account,
				Value = value
			};

			return debit;
		}

		private static void TransactionResult(string returnedValue)
		{
			Console.WriteLine($"Transaction confirmation: {returnedValue}");
		}
	}
}