using _1;
using System;

class Program
{
    static void Main()
    {
        IFileWriter fileWriter = new FileWriter();
        ILogger fileLogger = new FileLoggerAdapter(fileWriter);

        fileLogger.Log("This is a log message");
        fileLogger.Error("This is an error message");
        fileLogger.Warn("This is a warning message");
    }
}