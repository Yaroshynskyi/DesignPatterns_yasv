using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public class HtmlIterator
    {
        private Stack<LightNode> _stack = new Stack<LightNode>();

        public HtmlIterator(LightElementNode root)
        {
            _stack.Push(root);
        }

        public bool HasNext()
        {
            return _stack.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
                throw new InvalidOperationException();

            LightNode current = _stack.Pop();

            if (current is LightElementNode elementNode)
            {
                var children = elementNode.GetChildren();
                for (int i = children.Count - 1; i >= 0; i--)
                {
                    _stack.Push(children[i]);
                }
            }

            return current;
        }
    }


}
