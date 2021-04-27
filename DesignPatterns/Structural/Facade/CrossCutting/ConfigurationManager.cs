using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Facade.CrossCutting
{
	public class ConfigurationManager : IConfigurationManager
	{
		public string GetValue(string node)
			=> new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
				.Select(x => x[new Random().Next(x.Length)]).ToArray());
	}
}
