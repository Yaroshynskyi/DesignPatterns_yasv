using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNextHandler(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest();
    }
}
