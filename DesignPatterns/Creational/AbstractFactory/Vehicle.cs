using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Abstract Product
	public abstract class Vehicle
	{
		public string Name { get; set; }
		public Port Port { get; set; }

		protected Vehicle(string name, Port port)
		{
			Name = name;
			Port = port;
		}
	}
}
