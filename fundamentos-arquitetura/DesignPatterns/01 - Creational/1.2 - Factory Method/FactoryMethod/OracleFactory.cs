namespace DesignPatterns.FactoryMethod
{
    public class OracleFactory : DbFactory
    {
        //Factory Method (esse é Factory, devolvendo o DbConnector que é um produto abstrato)
        public override DbConnector CreateConnector(string connectionString)
        {
            //Retorna o produto especializado, é o produto concreto
            return new OracleDbConnector(connectionString);
        }
    }
}