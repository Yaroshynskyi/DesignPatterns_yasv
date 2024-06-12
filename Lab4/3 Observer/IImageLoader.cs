using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Observer
{
    public interface IImageLoader
    {
        void Load(string href);
    }
}
