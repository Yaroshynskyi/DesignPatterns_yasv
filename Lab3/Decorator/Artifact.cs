using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Artifact : IInventory
    {
        public void Equip()
        {
            Console.WriteLine("Artifact equipped");
        }
    }
}
