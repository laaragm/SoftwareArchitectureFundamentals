namespace SOLID.LSP
{
	public abstract class Paralelogram
	{
		public double Height { get; private set; }
		public double Width { get; private set; }
		public double Area 
		{ 
			get { return Height * Width; }
		}

		protected Paralelogram(int height, int width)
		{
			Height = height;
			Width = width;
		}

	}
}