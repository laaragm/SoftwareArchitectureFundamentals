namespace SOLID.OCP
{
	public static class DebitAccount
	{
		public static string PerformDirectDebit(this Debit debitAccount) => debitAccount.FormatTransaction();

	}
}