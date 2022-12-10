namespace DesignPatterns.Facade
{
    public interface IPagamentoCartaoCreditoFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}