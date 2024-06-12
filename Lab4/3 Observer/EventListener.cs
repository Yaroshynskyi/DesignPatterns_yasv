using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Observer
{
    public class EventListener : IEventListener
    {
        private readonly string _name;

        public EventListener(string name)
        {
            _name = name;
        }

        public void Update(string eventType)
        {
            Console.WriteLine($"{_name} received event: {eventType}");
        }
    }
}
