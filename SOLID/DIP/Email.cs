namespace SOLID.DIP
{
	public class Email
	{
		public string Address { get; set; }

		public bool Validate() => Address.Contains("@");

	}
}