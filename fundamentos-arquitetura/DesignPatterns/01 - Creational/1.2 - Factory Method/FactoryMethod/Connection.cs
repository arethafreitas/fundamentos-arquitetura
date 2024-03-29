﻿namespace DesignPatterns.FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executano comando: ", command);
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta");
        }
        public void Close()
        {
            Opened = false;
            Console.WriteLine("Conexão fechada");
        }


    }
}
