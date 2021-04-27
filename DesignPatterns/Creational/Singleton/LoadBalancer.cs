using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
	internal sealed class LoadBalancer
	{
		private static readonly LoadBalancer Instance = new LoadBalancer();
		private readonly IList<Server> Servers;
		private readonly Random Random = new Random();

		private LoadBalancer()
		{
			Servers = new List<Server>
			{
				new Server
				{
					ID = Guid.NewGuid(),
					Name = "Server 1",
					IP = "240.241.212.159"
				},
				new Server
				{
					ID = Guid.NewGuid(),
					Name = "Server 2",
					IP = "181.153.145.48"
				},
				new Server
				{
					ID = Guid.NewGuid(),
					Name = "Server 3",
					IP = "59.87.186.252"
				},
				new Server
				{
					ID = Guid.NewGuid(),
					Name = "Server 4",
					IP = "34.20.229.89"
				},
				new Server
				{
					ID = Guid.NewGuid(),
					Name = "Server 5",
					IP = "77.27.88.168"
				}
			};
		}

		public static LoadBalancer Get() => Instance;

		public Server NextServer
		{
			get
			{
				var random = Random.Next(Servers.Count());
				return Servers[random];
			}
		}

	}
}
