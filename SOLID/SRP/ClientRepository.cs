using System.Data;
using System.Data.SqlClient;

namespace SOLID.SRP
{
	public class ClientRepository
	{
		public void Add(Client client)
		{
			using (var connection = new SqlConnection())
			{
				var command = new SqlCommand();

				connection.ConnectionString = "connection string here";
				command.Connection = connection;
				command.CommandType = CommandType.Text;
				command.CommandText = "INSERT INTO CLIENTE (Name, Email, Cpf, Registration) VALUES (@name, @email, @cpf, @registration)";

				command.Parameters.AddWithValue("name", client.Name);
				command.Parameters.AddWithValue("email", client.Email);
				command.Parameters.AddWithValue("cpf", client.Cpf);
				command.Parameters.AddWithValue("registration", client.Registration);

				connection.Open();
				command.ExecuteNonQuery();
			}
		}
	}
}