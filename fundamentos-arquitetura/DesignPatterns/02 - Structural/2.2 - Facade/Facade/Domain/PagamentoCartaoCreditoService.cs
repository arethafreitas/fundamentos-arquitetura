using System.Linq;

namespace DesignPatterns.Facade
{
    //Classe de domínio
    public class PagamentoCartaoCreditoService : IPagamento
    {
        private readonly IPagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;

        public PagamentoCartaoCreditoService(IPagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade)
        {
            _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando pagamento via Cartão de Crédito. Valor: ", pagamento.Valor);

            if (_pagamentoCartaoCreditoFacade.RealizarPagamento(pedido, pagamento))
            {
                pagamento.Status = "Pago via Cartão de Crédito";
                return pagamento;
            }

            pagamento.Status = "Cartão de Crédito recusado!";
            return pagamento;
        }
    }
}