namespace DesignPatterns.Structutral
{
    public class ExecucaoAdapter
    {
      public static void Executar()
        {
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            //Recebe outro objeto adaptado pela interface que ele já conhece, por injeção de dependência
            var pagamentoLogCustomizado = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustomizado.RealizarTransacao();
        }
    }
}
