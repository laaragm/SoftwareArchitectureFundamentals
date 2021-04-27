using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Concrete Product
	public class MediumTowTruck : TowTruck
	{
		public MediumTowTruck(Port port) : base(port)
		{
		}

		public override void ProvideAssistance(Vehicle vehicle)
		{
			Console.WriteLine($"Assisting medium vehicle. Model: {vehicle.Name}");
		}
	}
}
