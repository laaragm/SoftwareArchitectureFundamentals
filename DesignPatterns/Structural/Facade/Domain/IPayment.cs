namespace DesignPatterns.Structural.Facade.Domain
{
	public interface IPayment
	{
		Payment Pay(Order order, Payment payment);
	}
}