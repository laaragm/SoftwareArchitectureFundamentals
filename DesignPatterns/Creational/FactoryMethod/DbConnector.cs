using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
	// Abstract Product
	public abstract class DbConnector
	{
		public string ConnectionString { get; set; }

		protected DbConnector(string connectionString)
		{
			ConnectionString = connectionString;
		}

		public abstract Connection Connect();
	}
}
