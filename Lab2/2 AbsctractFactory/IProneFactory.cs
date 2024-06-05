using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbsctractFactory
{
    class IProneFactory : DeviceFactory
    {
        public override Device CreateLaptop()
        {
            Console.WriteLine("Created IProne Laptop.");
            return new Laptop();
        }

        public override Device CreateNetbook()
        {
            Console.WriteLine("Created IProne Netbook.");
            return new Netbook();
        }

        public override Device CreateEBook()
        {
            Console.WriteLine("Created IProne EBook.");
            return new EBook();
        }

        public override Device CreateSmartphone()
        {
            Console.WriteLine("Created IProne Smartphone.");
            return new Smartphone();
        }
    }
}
