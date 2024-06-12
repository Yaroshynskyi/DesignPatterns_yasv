using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Memento
{
    public class DocumentMemento
    {
        private readonly string _content;

        public DocumentMemento(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
