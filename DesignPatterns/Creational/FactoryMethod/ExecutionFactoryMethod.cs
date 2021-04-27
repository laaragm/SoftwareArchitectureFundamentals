using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
	public class ExecutionFactoryMethod
	{
		public static void Run()
		{
			var sqlServerConnection = DbFactory
				.Database(DatabaseEnum.SqlServer)
				.CreateConnector("connection string sql server here")
				.Connect();
			sqlServerConnection.ExecuteCommand("SELECT * FROM SqlServerClient");
			sqlServerConnection.Close();

			Console.WriteLine("--------------------------------------------");

			var oracleConnection = DbFactory
				.Database(DatabaseEnum.Oracle)
				.CreateConnector("connection string oracle here")
				.Connect();
			oracleConnection.ExecuteCommand("SELECT * FROM OracleClient");
			oracleConnection.Close();
		}
	}
}
