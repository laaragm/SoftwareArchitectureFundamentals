using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	public class VehicleCreator
	{
		public static Vehicle Create(string name, Port port)
		{
			switch (port)
			{
				case Port.Large:
					return new LargeVehicle(name, port);
				case Port.Medium:
					return new MediumVehicle(name, port);
				case Port.Small:
					return new SmallVehicle(name, port);
				default:
					throw new ApplicationException("Sorry, we couldn't find the specified port");
			}
		}

	}
}
