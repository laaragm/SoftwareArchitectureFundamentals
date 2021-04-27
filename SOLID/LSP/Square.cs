using System;

namespace SOLID.LSP
{
	public class Square : Paralelogram
	{
		public Square(int height, int width) : base(height, width)
		{
			if(width != height)
				throw new ArgumentException("Both sides of the square need to have equal values");
		}

	}
}