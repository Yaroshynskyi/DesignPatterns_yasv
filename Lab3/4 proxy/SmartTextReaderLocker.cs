using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _4_proxy
{
    public class SmartTextReaderLocker
    {
        private SmartTextReader reader;
        private Regex fileRegex;

        public SmartTextReaderLocker(string filePath, string pattern)
        {
            reader = new SmartTextReader(filePath);
            fileRegex = new Regex(pattern);
        }

        public string[,] ReadText()
        {
            string[,] result = null;
            if (fileRegex.IsMatch(reader.ToString()))
            {
                Console.WriteLine("Access denied!");
            }
            else
            {
                result = reader.ReadText();
            }
            return result;
        }
    }
}
