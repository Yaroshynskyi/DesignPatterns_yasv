using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public class HtmlVisitor : IVisitor
    {
        public void Visit(LightElementNode elementNode)
        {
            Console.WriteLine($"Visiting element: <{elementNode.TagName}>");
            foreach (var child in elementNode.GetChildren())
            {
                child.Accept(this);
            }
        }

        public void Visit(LightTextNode textNode)
        {
            Console.WriteLine($"Visiting text: {textNode.OuterHtml}");
        }
    }
}
