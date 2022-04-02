namespace DesignPatterns.CrossCutting
{
    public interface IPayPalGateway
    {

        string GetPayPalServiceKey(string apiKey, string encriptionKey);
        string GetCardHashKey(string serviceKey, string pagamento);
        bool CommitTransaction(string cardHashKey, string pedido, decimal amount);

    }
}
