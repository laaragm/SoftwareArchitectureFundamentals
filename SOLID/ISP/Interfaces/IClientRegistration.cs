using SOLID.ISP.Interfaces;

namespace SOLID.ISP.Interfaces
{
	public interface IClientRegistration : IRegistration
	{
		void ValidateData();
		void SendEmail();
	}
}