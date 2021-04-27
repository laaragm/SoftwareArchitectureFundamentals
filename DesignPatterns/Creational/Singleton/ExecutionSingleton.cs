using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
	public class ExecutionSingleton
	{
		public static void Run()
		{
			var balancer1 = LoadBalancer.Get();
			var balancer2 = LoadBalancer.Get();
			var balancer3 = LoadBalancer.Get();
			var balancer4 = LoadBalancer.Get();

			if (balancer1 == balancer2 && balancer3 == balancer4)
				Console.WriteLine("Same instance");

			var balancer = LoadBalancer.Get();
			for (var i = 0; i < 15; i++) 
				Console.WriteLine($"Sending request to {balancer.NextServer.Name}, ID = {balancer.NextServer.ID}");
		}

	}
}
