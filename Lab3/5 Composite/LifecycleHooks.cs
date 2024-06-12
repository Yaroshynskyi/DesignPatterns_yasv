using _5_Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
public abstract class LifecycleHooks
{
    public virtual void OnCreated(LightElementNode element)
    {
        Console.WriteLine($"{element.TagName} element created.");
    }

    public virtual void OnInserted(LightElementNode element, LightNode child)
    {
        Console.WriteLine($"{child.GetType().Name} inserted into {element.TagName}.");
    }

    public virtual void OnRemoved(LightElementNode element, LightNode child)
    {
        Console.WriteLine($"{child.GetType().Name} removed from {element.TagName}.");
    }

    public virtual void OnStylesApplied(LightElementNode element)
    {
        Console.WriteLine($"Styles applied to {element.TagName}.");
    }

    public virtual void OnClassListApplied(LightElementNode element)
    {
        Console.WriteLine($"Class list applied to {element.TagName}.");
    }

    public virtual void OnTextRendered(LightElementNode element)
    {
        Console.WriteLine($"Text rendered in {element.TagName}.");
    }
}
}
