using _5_Composite;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        LifecycleHooks hooks = new ConcreteLifecycleHooks();
        LightElementNode div = new LightElementNode("div", true, false, hooks);
        div.AddClass("container");
        div.AddChild(new LightTextNode("Hello, World!"));

        LightElementNode span = new LightElementNode("span", false, false, hooks);
        span.AddChild(new LightTextNode("This is a span."));
        div.AddChild(span);

        Console.WriteLine(div.OuterHtml);

        HtmlIterator iterator = new HtmlIterator(div);
        Console.WriteLine("Iterating through HTML document:");
        while (iterator.HasNext())
        {
            var node = iterator.Next();
            Console.WriteLine(node.OuterHtml);
        }
    }
}