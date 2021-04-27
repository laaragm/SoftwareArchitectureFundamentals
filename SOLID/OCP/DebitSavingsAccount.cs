namespace SOLID.OCP
{
	public static class DebitSavingsAccount
	{
		public static string PerformDebitInSavingsAccount(this Debit debitAccount) => debitAccount.FormatTransaction();

	}
}