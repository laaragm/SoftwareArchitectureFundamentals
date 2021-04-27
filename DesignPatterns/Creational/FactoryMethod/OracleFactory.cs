using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
	// Concrete Creator
	public class OracleFactory : DbFactory
	{
		// Factory Method
		public override DbConnector CreateConnector(string connectionString)
		{
			return new OracleDbConnector(connectionString);
		}
	}
}
