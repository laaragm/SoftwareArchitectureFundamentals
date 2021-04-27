using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
	public abstract class ChocolateBuilder
	{
		public abstract void BuildIngredients();
		public abstract void BuildName();
		public abstract Chocolate GetResult();
	}
}
