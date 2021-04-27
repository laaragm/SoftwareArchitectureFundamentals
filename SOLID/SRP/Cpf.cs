namespace SOLID.SRP
{
	public class Cpf
	{
		public string Number { get; set; }

		public bool Validate() => Number.Length == 11;
	}
}