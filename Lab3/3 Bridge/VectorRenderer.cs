﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Bridge
{
    class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"{shape} as vector graphics");
        }
    }
}
