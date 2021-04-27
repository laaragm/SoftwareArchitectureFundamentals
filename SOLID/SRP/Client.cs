using System;

namespace SOLID.SRP
{
	public class Client
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public Email Email { get; set; }
		public Cpf Cpf { get; set; }
		public DateTime Registration { get; set; }

		public bool Validate() => Email.Validate() && Cpf.Validate();
	}
}