namespace DesignPatterns.FactoryMethod
{
    public class ExecutarFactoryMethod
    {
        public static void Executar()
        {
            var sqlServerConnection = DbFactory.Database(DataBase.SqlServer)
                .CreateConnector(connectionString: "minhaConnectionString")
                .Connect();
            sqlServerConnection.ExecuteCommand("SELECT * FROM TabelaSQLServer");
            sqlServerConnection.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            var oracleConnection = DbFactory.Database(DataBase.Oracle)
                .CreateConnector(connectionString: "minhaConnectionString")
                .Connect();
            oracleConnection.ExecuteCommand("SELECT * FROM TabelaOracle");
            oracleConnection.Close();
        }
    }
}