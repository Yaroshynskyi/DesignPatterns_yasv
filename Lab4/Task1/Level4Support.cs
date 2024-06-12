using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Level4Support : SupportHandler
    {
        public override void HandleRequest()
        {
            Console.WriteLine("Level 4 Support: What is your hardware issue?");
            Console.WriteLine("1. Replace parts");
            Console.WriteLine("2. Send to service center");
            Console.WriteLine("3. Other");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Level 4 Support: Your parts will be replaced.");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Level 4 Support: Your device will be sent to the service center.");
            }
            else
            {
                Console.WriteLine("Level 4 Support: Please specify your issue more clearly.");
            }
        }
    }
}
