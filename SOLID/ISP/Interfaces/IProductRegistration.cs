using SOLID.ISP.Interfaces;

namespace SOLID.ISP.Interfaces
{
	public interface IProductRegistration : IRegistration
	{
		void ValidateData();
	}
}