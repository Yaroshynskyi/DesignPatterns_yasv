using System;
using System.IO;
using System.Text.RegularExpressions;
using _4_proxy;

class Program
{
    static void Main(string[] args)
    {
        using (SmartTextChecker checker = new SmartTextChecker("example.txt"))
        {
            checker.ReadText();
        }

        SmartTextReaderLocker locker = new SmartTextReaderLocker("example.txt", @"^(?!restricted_).*\.txt$");
        locker.ReadText();
    }
}