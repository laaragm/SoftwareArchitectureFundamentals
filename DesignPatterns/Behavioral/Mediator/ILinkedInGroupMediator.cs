using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
	public interface ILinkedInGroupMediator
	{
		void RegisterUser(IUser user);
		void SendMessage(string message, IUser user);
	}
}
