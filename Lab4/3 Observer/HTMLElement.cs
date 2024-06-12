using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Observer
{
    public abstract class HTMLElement
    {
        private readonly Dictionary<string, List<IEventListener>> _listeners = new Dictionary<string, List<IEventListener>>();

        public void AddEventListener(string eventType, IEventListener listener)
        {
            if (!_listeners.ContainsKey(eventType))
            {
                _listeners[eventType] = new List<IEventListener>();
            }
            _listeners[eventType].Add(listener);
        }

        public void RemoveEventListener(string eventType, IEventListener listener)
        {
            if (_listeners.ContainsKey(eventType))
            {
                _listeners[eventType].Remove(listener);
            }
        }

        protected void Notify(string eventType)
        {
            if (_listeners.ContainsKey(eventType))
            {
                foreach (var listener in _listeners[eventType])
                {
                    listener.Update(eventType);
                }
            }
        }

        public abstract void Render();
    }
}
