using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	// Client: deals with the abstract products (in our case Vehicle and TowTruck) and the abstract factory (in our case
	// TowTruckFactory) and later we specify this applying what you need given a specific scenery
	// This is the "real world" class which would be responsible for opening the occurrence, finding the correct tow truck given the 
	// vehicle, location and etc
	public class TowService
	{
		private readonly Vehicle Vehicle;
		private readonly TowTruck TowTruck;

		// You create an abstraction where you have a factory which will create the components regardless of specialization
		public TowService(TowTruckFactory factory, Vehicle vehicle)
		{
			TowTruck = factory.CreateTowTruck();
			Vehicle = factory.CreateVehicle(vehicle.Name, vehicle.Port);
		}

		public void AssistVehicle() => TowTruck.ProvideAssistance(Vehicle);

		// For each scenery we have a concrete factory specilialized in solving that specific problem
		public static TowService CreateTowService(Vehicle vehicle)
		{
			switch (vehicle.Port)
			{
				case Port.Large:
					return new TowService(new TowTruckLargeVehicleFactory(), vehicle);
				case Port.Medium:
					return new TowService(new TowTruckMediumVehicleFactory(), vehicle);
				case Port.Small:
					return new TowService(new TowTruckSmallVehicleFactory(), vehicle);
				default:
					throw new ApplicationException("The vehicle could not be identified");
			}
		}
	}
}
