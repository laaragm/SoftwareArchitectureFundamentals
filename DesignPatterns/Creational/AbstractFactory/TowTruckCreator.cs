using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	public class TowTruckCreator
	{
		public static TowTruck Create(Port port)
		{
			switch (port) 
			{
				case Port.Large:
					return new LargeTowTruck(port);
				case Port.Medium:
					return new MediumTowTruck(port);
				case Port.Small:
					return new SmallTowTruck(port);
				default:
					throw new ApplicationException("Sorry, we couldn't find the specified port");
			}
			
		}
	}
}
