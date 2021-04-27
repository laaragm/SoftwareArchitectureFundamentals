﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
	public class Connection
	{
		public string ConnectionString { get; set; }
		public bool Opened { get; set; }

		public Connection(string connectionString)
		{
			ConnectionString = connectionString;
		}

		public void ExecuteCommand(string command)
		{
			Console.WriteLine($"Executing command: {command}");
		}

		public void Open()
		{
			Opened = true;
			Console.WriteLine("Connection opened");
		}

		public void Close()
		{
			Opened = false;
			Console.WriteLine("Connection closed");
		}
	}
}
