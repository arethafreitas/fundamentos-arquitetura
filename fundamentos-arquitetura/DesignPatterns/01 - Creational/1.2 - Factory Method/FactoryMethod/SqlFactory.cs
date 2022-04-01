namespace DesignPatterns.FactoryMethod
{
    //Concrete Creator
    public class SqlFactory : DbFactory
    {
     //Factory Method (esse é Factory, devolvendo o DbConnector que é um produto abstrato)
     public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
