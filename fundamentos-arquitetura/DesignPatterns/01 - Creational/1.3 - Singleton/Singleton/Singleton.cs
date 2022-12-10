namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        public const int LIMITE = 15;
        public static void Executar()
        {
            var firstLoadBalancer = LoadBalancer.GetLoadBalancer();
            var secondLoadBalancer = LoadBalancer.GetLoadBalancer();
            var thirdLoadBalancer = LoadBalancer.GetLoadBalancer();
            var forthLoadBalancer = LoadBalancer.GetLoadBalancer();

            if (firstLoadBalancer == secondLoadBalancer && secondLoadBalancer == thirdLoadBalancer
                && thirdLoadBalancer == forthLoadBalancer)
            {
                Console.WriteLine("Mesma instância \n");

                var balancer = LoadBalancer.GetLoadBalancer();

                for (var i = 0; 1 < LIMITE; i++)
                {
                    var serverName = balancer.NextServer.Name;
                    Console.WriteLine("Disparando request para: ", serverName);
                }
            }
        }
    }
}
