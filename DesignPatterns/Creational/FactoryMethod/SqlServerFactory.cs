using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
	// Concrete Creator
	public class SqlServerFactory : DbFactory 
	{
		// Factory Method
		public override DbConnector CreateConnector(string connectionString)
		{
			return new SqlServerDbConnector(connectionString);
		}
	}
}
