using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

public class SmartTextReader : IDisposable
{
    private StreamReader reader;

    public SmartTextReader(string filePath)
    {
        reader = new StreamReader(filePath);
    }

    public string[,] ReadText()
    {
        string text = reader.ReadToEnd();
        string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        string[,] result = new string[lines.Length, 0];

        for (int i = 0; i < lines.Length; i++)
        {
            result[i, 0] = lines[i];
        }

        return result;
    }

    public void Dispose()
    {
        reader.Close();
    }
}
