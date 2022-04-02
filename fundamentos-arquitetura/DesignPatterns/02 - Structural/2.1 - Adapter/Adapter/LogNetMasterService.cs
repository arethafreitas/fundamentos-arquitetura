namespace DesignPatterns.Structutral
{
    //Adaptee class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log customizado: ", message);
        }
        public void LogException(Exception exception)
        {
            Console.WriteLine("Log customizado: ", exception.Message);
        }
    }
}