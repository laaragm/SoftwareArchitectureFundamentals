using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Concrete Factory
	public class TowTruckLargeVehicleFactory : TowTruckFactory
	{
		public override TowTruck CreateTowTruck() => TowTruckCreator.Create(Port.Large);
		public override Vehicle CreateVehicle(string name, Port port)
			=> VehicleCreator.Create(name, port);

	}
}
