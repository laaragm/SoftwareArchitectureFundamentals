using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
	// Concrete Product
	public class SqlServerDbConnector : DbConnector
	{
		public SqlServerDbConnector(string connectionString) : base(connectionString)
		{
			ConnectionString = connectionString;
		}

		public override Connection Connect()
		{
			Console.WriteLine("Connecting to SQL Server");
			var connection = new Connection(ConnectionString);
			connection.Open();

			return connection;
		}
	}
}
