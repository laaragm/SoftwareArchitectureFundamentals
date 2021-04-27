using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Concrete Product
	public class LargeVehicle : Vehicle
	{
		public LargeVehicle(string name, Port port) : base(name, port)
		{
		}
	}
}
