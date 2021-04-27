using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using System;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			var option = SelectOption();
			RunPatternBasedOnSelectedOption(option);
		}

		static string SelectOption()
		{
			Console.WriteLine("Select a valid option:");
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("Creational Patterns");
			Console.WriteLine("1. Builder");
			Console.WriteLine("2. Abstract Factory");
			Console.WriteLine("3. Factory Method");
			Console.WriteLine("4. Singleton");
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("Structural Patterns");
			Console.WriteLine("5. Apdapter");
			Console.WriteLine("6. Facade");
			Console.WriteLine("7. Composite");
			Console.WriteLine("8. Decorator");
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("Behavioral Patterns");
			Console.WriteLine("9. Command");
			Console.WriteLine("10. Strategy");
			Console.WriteLine("11. Observer");
			Console.WriteLine("12. Mediator");
			Console.WriteLine("----------------------------------------");

			var option = Console.ReadLine();
			Console.WriteLine("\n\n----------------------------------------");
			return option;
		}

		static void RunPatternBasedOnSelectedOption(string option)
		{
			switch (option)
			{
				case "1":
					ExecutionBuilderPattern.Run();
					break;
				case "2":
					ExecutionAbstractFactory.Run();
					break;
				case "3":
					ExecutionFactoryMethod.Run();
					break;
				case "4":
					ExecutionSingleton.Run();
					break;
				case "5":
					ExecutionAdapter.Run();
					break;
				case "6":
					ExecutionFacade.Run();
					break;
				case "7":
					ExecutionComposite.Run();
					break;
				case "8":
					ExecutionDecorator.Run();
					break;
				case "9":
					ExecutionCommand.Run();
					break;
				case "10":
					ExecutionStrategy.Run();
					break;
				case "11":
					ExecutionObserver.Run();
					break;
				case "12":
					ExecutionMediator.Run();
					break;
				default:
					throw new InvalidOperationException();
			}
		}
	}
}
