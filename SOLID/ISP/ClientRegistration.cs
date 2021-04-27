using SOLID.ISP.Interfaces;

namespace SOLID.ISP
{
	public class ClientRegistration : IClientRegistration
	{
		public void ValidateData()
		{
			// Validate email and cpf, for example
		}

		public void Save()
		{
			// Insert
		}

		public void SendEmail()
		{
			// Send email to the client
		}
	}
}