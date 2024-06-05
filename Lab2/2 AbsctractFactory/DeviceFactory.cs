using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbsctractFactory
{
    abstract class DeviceFactory
    {
        public abstract Device CreateLaptop();
        public abstract Device CreateNetbook();
        public abstract Device CreateEBook();
        public abstract Device CreateSmartphone();
    }
}