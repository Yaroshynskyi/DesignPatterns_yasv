﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbsctractFactory
{
    class Netbook : Device
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a Netbook.");
        }
    }
}
