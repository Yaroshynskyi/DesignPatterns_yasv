using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Weapon : IInventory
    {
        public void Equip()
        {
            Console.WriteLine("Weapon equipped");
        }
    }
}
