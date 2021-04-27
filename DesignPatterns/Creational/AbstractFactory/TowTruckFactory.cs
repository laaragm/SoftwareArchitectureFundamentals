using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Abstract Factory
	public abstract class TowTruckFactory
	{
		public abstract TowTruck CreateTowTruck();
		public abstract Vehicle CreateVehicle(string name, Port port);
	}
}
