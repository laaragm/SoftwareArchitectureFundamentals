using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
	public class ExecutionComposite
	{
		public static void Run()
		{
			var registerValidation = new Message("Register could not be realized successfully");

			var userFormError = new Message("The user didn't inform a valid name");
			var sizeNameForm = new InputFormMessage("The name must contain more than 2 characters");
			var emptyNameForm = new InputFormMessage("The name cannot have numbers");
			userFormError.AddChild(sizeNameForm);
			userFormError.AddChild(emptyNameForm);
			registerValidation.AddChild(userFormError);

			var domainUserError = new Message("A few problems were found while processing the user registration");
			var cpfUserDomain = new DomainMessage("The informed CPF is already being used");
			var emailUserDomain = new DomainMessage("The informed email is already being used");
			domainUserError.AddChild(cpfUserDomain);
			domainUserError.AddChild(emailUserDomain);
			registerValidation.AddChild(domainUserError);

			var messageLevel1 = new Message("Level 1");
			var messageLevel2 = new Message("Level 2");
			var messageLevel3 = new Message("Level 3");
			var messageLevel4 = new Message("Level 4");
			var messageLevel5 = new Message("Level 5");
			messageLevel1.AddChild(messageLevel2);
			messageLevel2.AddChild(messageLevel3);
			messageLevel3.AddChild(messageLevel4);
			messageLevel4.AddChild(messageLevel5);
			registerValidation.AddChild(messageLevel1);

			registerValidation.ShowMessages(2);
		}
	}
}
