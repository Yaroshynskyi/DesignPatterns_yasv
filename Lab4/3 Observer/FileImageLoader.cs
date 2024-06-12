using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Observer
{
    public class FileImageLoader : IImageLoader
    {
        public void Load(string href)
        {
            Console.WriteLine($"Loading image from file system: {href}");
        }
    }
}
