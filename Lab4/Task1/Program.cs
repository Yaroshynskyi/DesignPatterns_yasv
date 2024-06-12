using Task1;
using System;


class Program
{
    static void Main(string[] args)
    {
        SupportHandler level1 = new Level1Support();
        SupportHandler level2 = new Level2Support();
        SupportHandler level3 = new Level3Support();
        SupportHandler level4 = new Level4Support();

        level1.SetNextHandler(level2);
        level2.SetNextHandler(level3);
        level3.SetNextHandler(level4);

        while (true)
        {
            Console.WriteLine("Welcome to the support system.");
            level1.HandleRequest();

            Console.WriteLine("Do you need more support? (y/n)");
            string moreSupport = Console.ReadLine();
            if (moreSupport.ToLower() != "y")
            {
                break;
            }
        }
    }
}