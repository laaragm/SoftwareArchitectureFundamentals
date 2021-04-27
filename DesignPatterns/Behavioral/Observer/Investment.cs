using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
	// Subject
	public abstract class Investment
	{
		private decimal Value;
		private readonly IList<IObserver> Observers = new List<IObserver>();
		public string Symbol { get; }
		public decimal GetValue
		{
			get => Value;
			set
			{
				if (Value == value) 
					return;

				Value = value;
				Notify();
			}
		}

		protected Investment(string symbol, decimal value)
		{
			Symbol = symbol;
			Value = value;
		}

		public void Subscribe(IObserver observer)
		{
			Observers.Add(observer);
			Console.WriteLine($"Notifying that {observer.Name} is receiving updates from {Symbol}");
		}

		public void Unsubscribe(IObserver observer)
		{
			Observers.Remove(observer);
			Console.WriteLine($"Notifying that {observer.Name} is no more receiving updates from {Symbol}");
		}

		private void Notify()
		{
			foreach (var investor in Observers)
				investor.Notify(this);
		}
	}
}
