using SOLID.DIP.Interfaces;

namespace SOLID.DIP
{
	public class ClienteServices : IClientService
	{
		private readonly IClientRepository ClientRepository;
		private readonly IEmailService EmailService;

		public ClienteServices(IEmailService emailService, IClientRepository clientRepository)
		{
			EmailService = emailService;
			ClientRepository = clientRepository;
		}

		public string Add(Client cliente)
		{
			if (!cliente.Validate())
				return "Invalid data";

			ClientRepository.Add(cliente);
			EmailService.Send("company@empresa.company", cliente.Email.Address, "Welcome!", "You're registered");

			return "User registered successfully";
		}
	}
	
}