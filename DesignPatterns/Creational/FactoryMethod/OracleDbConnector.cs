using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
	// Concrete Product
	public class OracleDbConnector : DbConnector
	{
		public OracleDbConnector(string connectionString) : base(connectionString)
		{
			ConnectionString = connectionString;
		}

		public override Connection Connect()
		{
			Console.WriteLine("Connecting to Oracle");
			var connection = new Connection(ConnectionString);
			connection.Open();

			return connection;
		}
	}
}
