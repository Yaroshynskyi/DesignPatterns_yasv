using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _4_proxy
{
    public class SmartTextChecker : IDisposable
    {
        private SmartTextReader reader;
        private int totalLines;
        private int totalCharacters;

        public SmartTextChecker(string filePath)
        {
            reader = new SmartTextReader(filePath);
            Log("File opened successfully.");
        }

        public string[,] ReadText()
        {
            string[,] result = reader.ReadText();
            totalLines = result.GetLength(0);
            totalCharacters = 0;

            for (int i = 0; i < result.GetLength(0); i++)
            {
                totalCharacters += result[i, 0].Length;
            }

            Log($"Read {totalLines} lines and {totalCharacters} characters.");
            return result;
        }

        public void Dispose()
        {
            reader.Dispose();
            Log("File closed.");
        }

        private void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
