using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Concrete Product
	public class MediumVehicle : Vehicle
	{
		public MediumVehicle(string name, Port port) : base(name, port)
		{
		}
	}
}
