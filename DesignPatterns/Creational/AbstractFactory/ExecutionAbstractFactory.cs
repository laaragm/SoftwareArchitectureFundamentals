using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
	public class ExecutionAbstractFactory
	{
		public static void Run()
		{
			var rescueVehicle = new List<Vehicle>
			{
				VehicleCreator.Create("BMW X7", Port.Large),
				VehicleCreator.Create("Jeep Compass", Port.Medium),
				VehicleCreator.Create("Hyundai HB20", Port.Small),
			};
			rescueVehicle.ForEach(x => TowService.CreateTowService(x).AssistVehicle());
		}
	}
}
