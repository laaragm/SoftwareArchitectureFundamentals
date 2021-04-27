using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
	public class LinkedInGroupMediator : ILinkedInGroupMediator
	{
		private IList<IUser> Users = new List<IUser>();

		public void RegisterUser(IUser user) => Users.Add(user);

		public void SendMessage(string message, IUser user)
		{
			foreach (var item in Users)
			{
				if (item != user)
					item.Receive(message);
			}
		}
	}
}
