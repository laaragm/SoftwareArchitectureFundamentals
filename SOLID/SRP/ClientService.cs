namespace SOLID.SRP
{
	public class ClientService
	{
		public string Add(Client client)
		{
			if (!client.Validate())
				return "Invalid data";

			var clientRepository = new ClientRepository();
			clientRepository.Add(client);

			EmailServices.Send("company@company.com", client.Email.Address, "Welcome!", "You're now registered");

			return "User registered successfully";
		}
	}
}