namespace DesignPatterns.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                //nunca cria instâncias do objeto, e sim criações desse objeto
                VeiculoCreator.Criar(modelo: "Celta", Porte.Pequeno),
                VeiculoCreator.Criar(modelo: "Jetta", Porte.Medio),
                VeiculoCreator.Criar(modelo: "BMW X6", Porte.Grande),
            };
            veiculosSocorro.ForEach(action: v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}
