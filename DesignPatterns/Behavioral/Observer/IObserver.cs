namespace DesignPatterns.Behavioral.Observer
{
	public interface IObserver
	{
		void Notify(Investment investment);
		string Name { get; }
	}
}