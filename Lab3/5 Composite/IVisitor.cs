using _5_Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
public interface IVisitor
{
    void Visit(LightElementNode elementNode);
    void Visit(LightTextNode textNode);
}

}

