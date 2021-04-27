using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
	public class ChocolateDirector
	{
		public void Create(ChocolateBuilder builder)
		{
			builder.BuildName();
			builder.BuildIngredients();
		}
	}
}
