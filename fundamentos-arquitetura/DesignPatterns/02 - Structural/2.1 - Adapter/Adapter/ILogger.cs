﻿namespace DesignPatterns.Structutral
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}
