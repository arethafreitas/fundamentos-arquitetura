namespace DesignPatterns.Structutral
{
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}