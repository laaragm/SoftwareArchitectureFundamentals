using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
	// Composite
	public class Message : IMessage, IEnumerable<IMessage>
	{
		public string Name { get; set; }
		private readonly IList<IMessage> List = new List<IMessage>();

		public Message(string name)
		{
			Name = name;
		}

		public void AddChild(IMessage child) => List.Add(child);

		public void RemoveChild(IMessage child) => List.Remove(child);
		
		public IMessage GetChild(string name) => List.First(x => x.Name == name);

		public IMessage GetChild(int index) => List[index];

		public IEnumerable<IMessage> GetList(int index) => List;

		public void ShowMessages(int level)
		{
			Console.WriteLine(new string('-', level) + Name);
			foreach (var message in List)
				message.ShowMessages(level + 2);
		}

		public IEnumerator<IMessage> GetEnumerator() => ((IEnumerable <IMessage>)List).GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<IMessage>)List).GetEnumerator();

	}
}
