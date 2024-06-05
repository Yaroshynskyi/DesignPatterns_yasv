using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Bridge
{
    class RasterRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"{shape} as raster graphics");
        }
    }
}
