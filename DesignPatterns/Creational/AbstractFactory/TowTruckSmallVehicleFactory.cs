using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Concrete Factory
	public class TowTruckSmallVehicleFactory : TowTruckFactory
	{
		public override TowTruck CreateTowTruck() => TowTruckCreator.Create(Port.Small);
		public override Vehicle CreateVehicle(string name, Port port)
			=> VehicleCreator.Create(name, port);

	}
}
