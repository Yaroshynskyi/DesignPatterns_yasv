using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class FileLoggerAdapter : ILogger
    {
        private readonly IFileWriter _fileWriter;

        public FileLoggerAdapter(IFileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _fileWriter.WriteLine($"Log: {message}");
            Console.ResetColor();
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            _fileWriter.WriteLine($"Error: {message}");
            Console.ResetColor();
        }

        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            _fileWriter.WriteLine($"Warning: {message}");
            Console.ResetColor();
        }
    }
}
