using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
	public class User : IUser
	{
		protected ILinkedInGroupMediator Mediator;
		protected string Name;

		public User(ILinkedInGroupMediator mediator, string name)
		{
			Mediator = mediator;
			Name = name;
		}

		public void Receive(string message)
		{
			Console.WriteLine($"{Name}, received message: {message}");
		}

		public void Send(string message)
		{
			Console.WriteLine($"{Name}, sending message: {message}");
			Mediator.SendMessage(message, this);
		}
	}
}
