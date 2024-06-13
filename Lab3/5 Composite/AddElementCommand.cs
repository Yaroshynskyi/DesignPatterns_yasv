using _5_Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
public class AddElementCommand : Command
{
    private LightElementNode _parent;
    private LightNode _child;

    public AddElementCommand(LightElementNode parent, LightNode child)
    {
        _parent = parent;
        _child = child;
    }

    public override void Execute()
    {
        _parent.AddChild(_child);
    }

    public override void Undo()
    {
        _parent.RemoveChild(_child);
    }
}
}
