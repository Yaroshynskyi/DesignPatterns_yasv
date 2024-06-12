using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Level1Support : SupportHandler
    {
        public override void HandleRequest()
        {
            Console.WriteLine("Level 1 Support: What is your issue?");
            Console.WriteLine("1. Billing issue");
            Console.WriteLine("2. Technical issue");
            Console.WriteLine("3. Other");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Level 1 Support: Your billing issue has been resolved.");
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
                Console.WriteLine("Level 1 Support: Please specify your issue more clearly.");
            }
        }
    }
}
