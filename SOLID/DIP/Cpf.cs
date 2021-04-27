namespace SOLID.DIP
{
	public class Cpf
	{
		public string Number { get; set; }

		public bool Validate() => Number.Length == 11;

	}
}