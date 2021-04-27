namespace SOLID.DIP.Interfaces
{
	public interface IEmailService
	{
		void Send(string from, string to, string subject, string message);
	}
}