using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Level3Support : SupportHandler
    {
        public override void HandleRequest()
        {
            Console.WriteLine("Level 3 Support: What is your device malfunction issue?");
            Console.WriteLine("1. Software issue");
            Console.WriteLine("2. Hardware issue");
            Console.WriteLine("3. Other");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Level 3 Support: Your software issue has been resolved.");
            }
            else if (choice == "2")
            {
                if (nextHandler != null)
                {
                    nextHandler.HandleRequest();
                }
            }
            else
            {
                Console.WriteLine("Level 3 Support: Please specify your issue more clearly.");
            }
        }
    }

}
