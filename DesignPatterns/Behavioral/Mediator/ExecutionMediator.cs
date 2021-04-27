using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
	public class ExecutionMediator
	{
		public static void Run()
		{
			ILinkedInGroupMediator mediator = new LinkedInGroupMediator();

			IUser lara = new User(mediator, "Lara");
			IUser harry = new User(mediator, "Harry");
			IUser jord = new User(mediator, "Jord");

			mediator.RegisterUser(lara);
			mediator.RegisterUser(harry);
			mediator.RegisterUser(jord);
			
			lara.Send("i'm currently studying design patterns");
			Console.WriteLine();
			harry.Send("really? i bet you're learning a lot");
			Console.WriteLine();
			jord.Send("nice!");
			Console.WriteLine();
			lara.Send("yup, found some great tutorials and courses online");
		}

	}
}
