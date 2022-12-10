namespace DesignPatterns.Facade
{
    public class Pedido
    {
        public Guid ID { get; set; }
        public decimal Valor { get; set;}
        public List<Produto> Produtos { get; set; }
    }
}
