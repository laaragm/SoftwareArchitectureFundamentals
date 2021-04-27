using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Concrete Product
	public class SmallVehicle : Vehicle
	{
		public SmallVehicle(string name, Port port) : base(name, port)
		{
		}
	}
}
