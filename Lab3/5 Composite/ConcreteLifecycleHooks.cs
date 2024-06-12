using _5_Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
public class ConcreteLifecycleHooks : LifecycleHooks
{
    public override void OnCreated(LightElementNode element)
    {
        base.OnCreated(element);
    }

    public override void OnInserted(LightElementNode element, LightNode child)
    {
        base.OnInserted(element, child);
    }

    public override void OnRemoved(LightElementNode element, LightNode child)
    {
        base.OnRemoved(element, child);
    }

    public override void OnStylesApplied(LightElementNode element)
    {
        base.OnStylesApplied(element);
    }

    public override void OnClassListApplied(LightElementNode element)
    {
        base.OnClassListApplied(element);
    }

    public override void OnTextRendered(LightElementNode element)
    {
        base.OnTextRendered(element);
    }
}
}
