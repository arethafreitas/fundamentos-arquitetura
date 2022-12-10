namespace DesignPatterns.Singleton
{
    //Selada para evitar uma possível abstração
    internal sealed class LoadBalancer
    {
        //Pode ser usado para testes de carga
        //Propriedade da própria classe, criando uma instância, mantendo-a (por ser estática)
        private static readonly LoadBalancer Instance = new LoadBalancer();
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        //Cria a instância do objeto e popula a lista, retornando sempre o mesmo objeto (Instance)
        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ ID = Guid.NewGuid(), Name = "Credenciadora BI", IP = "10.84.71.1"},
                new Server{ ID = Guid.NewGuid(), Name = "MBF", IP = "10.84.71.2"},
                new Server{ ID = Guid.NewGuid(), Name = "MBJ", IP = "10.84.71.3"},
                new Server{ ID = Guid.NewGuid(), Name = "SPD", IP = "10.84.71.4"},
                new Server{ ID = Guid.NewGuid(), Name = "MBX", IP = "10.84.71.5"},
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                //Gera um número randômico com base no total de servidores que eu tenho
                var randomServers = _random.Next(_servers.Count);
                return _servers[randomServers];
            }
        }
    }
}