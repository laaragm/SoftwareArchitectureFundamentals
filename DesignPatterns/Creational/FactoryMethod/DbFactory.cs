using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
	// Abstract Creator
	public abstract class DbFactory
	{
		// Factory Method
		public abstract DbConnector CreateConnector(string connectionString);

		public static DbFactory Database(DatabaseEnum database)
		{
			if (database == DatabaseEnum.Oracle)
				return new OracleFactory();
			if (database == DatabaseEnum.SqlServer)
				return new SqlServerFactory();
			throw new ApplicationException("Database not found");
		}
	}
}
