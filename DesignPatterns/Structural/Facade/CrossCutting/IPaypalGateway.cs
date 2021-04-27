namespace DesignPatterns.Structural.Facade.CrossCutting
{
	public interface IPaypalGateway
	{
		bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
		string GetCardHashKey(string serviceKey, string creditCard);
		string GetPaypalServiceKey(string apiKey, string encriptionKey);
	}
}