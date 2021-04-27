using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Concrete Product
	public class SmallTowTruck : TowTruck
	{
		public SmallTowTruck(Port port) : base(port)
		{
		}

		public override void ProvideAssistance(Vehicle vehicle)
		{
			Console.WriteLine($"Assisting small vehicle. Model: {vehicle.Name}");
		}
	}
}
