﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Observer
{
    public interface IEventListener
    {
        void Update(string eventType);
    }
}
