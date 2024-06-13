using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            this._text = text;
        }

        public override string OuterHtml => _text;
        public override string InnerHtml => _text;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
