using System;

namespace SOLID.DIP
{
	public class Client
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public Email Email { get; set; }
		public Cpf Cpf { get; set; }
		public DateTime RegistrationDate { get; set; }

		public bool Validate() => Email.Validate() && Cpf.Validate();
	   
	}
}