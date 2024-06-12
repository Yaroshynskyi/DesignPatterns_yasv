using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Level2Support : SupportHandler
    {
        public override void HandleRequest()
        {
            Console.WriteLine("Level 2 Support: What is your technical issue?");
            Console.WriteLine("1. Internet connectivity");
            Console.WriteLine("2. Device malfunction");
            Console.WriteLine("3. Other");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Level 2 Support: Your internet connectivity issue has been resolved.");
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
                Console.WriteLine("Level 2 Support: Please specify your issue more clearly.");
            }
        }
    }

}
