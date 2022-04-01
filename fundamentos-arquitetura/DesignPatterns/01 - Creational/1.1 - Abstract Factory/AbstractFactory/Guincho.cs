namespace DesignPatterns.AbstractFactory
{
    public abstract class Guincho
    {
        //AbstractProduct
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
        public Porte Porte { get; set; }
    }

    //Produto concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }
        public override void Socorrer(Veiculo veiculo)
        {
            //Processo de socorro
            Console.WriteLine(value: "Socorrendo Carro Pequeno - Modelo" + veiculo.Modelo);
        }
    }
    //Produto concreto
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }
        public override void Socorrer(Veiculo veiculo)
        {
            //Processo de socorro
            Console.WriteLine(value: "Socorrendo Carro Médio - Modelo" + veiculo.Modelo);
        }
    }
    //Produto concreto
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }
        public override void Socorrer(Veiculo veiculo)
        {
            //Processo de socorro
            Console.WriteLine(value: "Socorrendo Carro Grande - Modelo" + veiculo.Modelo);
        }
    }

    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new ApplicationException(message: "Porte de Guincho desconhecido.");
            }
        }
    }
}
