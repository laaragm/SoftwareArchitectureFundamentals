using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Abstract Product
	public abstract class TowTruck
	{
		public Port Port { get; set; }

		protected TowTruck(Port port)
		{
			Port = port;
		}

		public abstract void ProvideAssistance(Vehicle vehicle);

	}
}
