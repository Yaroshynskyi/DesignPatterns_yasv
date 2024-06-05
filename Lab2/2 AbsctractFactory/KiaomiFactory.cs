using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbsctractFactory
{
    class KiaomiFactory : DeviceFactory
    {
        public override Device CreateLaptop()
        {
            Console.WriteLine("Created Kiaomi Laptop.");
            return new Laptop();
        }

        public override Device CreateNetbook()
        {
            Console.WriteLine("Created Kiaomi Netbook.");
            return new Netbook();
        }

        public override Device CreateEBook()
        {
            Console.WriteLine("Created Kiaomi EBook.");
            return new EBook();
        }

        public override Device CreateSmartphone()
        {
            Console.WriteLine("Created Kiaomi Smartphone.");
            return new Smartphone();
        }
    }

}
