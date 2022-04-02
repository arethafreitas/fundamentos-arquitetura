using DesignPatterns.CrossCutting;

namespace DesignPatterns.Facade
{
    public class ExecucaoFacade
    {
        public static void Executar()
        {
            var produtos = new List<Produto>
            {
                new Produto { Nome = "Livro Pragmatic Programmer", Valor = new Random().Next(500)},
                new Produto { Nome = "Livro Codificador Limpo", Valor = new Random().Next(500)},
                new Produto { Nome = "Livro Arquitetura Limpa", Valor = new Random().Next(500)},
            };

            var pedido = new Pedido()
            {
                ID = Guid.NewGuid(),
                Produtos = produtos
            };

            var pagamento = new Pagamento
            {
                CartaoCredito = "5555 4444 3333 2222"
            };

            //Resolva com DI
            var pagamentoService = new PagamentoCartaoCreditoService
                (new PagamentoCartaoCreditoFacade(new PayPalGateway(), new ConfigurationManager()));

            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);
            Console.WriteLine(pagamentoResult.Status);
        }
    }
}
