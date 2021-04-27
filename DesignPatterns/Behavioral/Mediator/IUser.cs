using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
	public interface IUser
	{
		void Send(string message);
		void Receive(string message);
	}
}
