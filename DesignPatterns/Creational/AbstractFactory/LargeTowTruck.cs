using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Concrete Product
	public class LargeTowTruck : TowTruck
	{
		public LargeTowTruck(Port port) : base(port)
		{
		}

		public override void ProvideAssistance(Vehicle vehicle)
		{
			Console.WriteLine($"Assisting large vehicle. Model: {vehicle.Name}");
		}
	}
}
