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

        LightTextNode textNode = new LightTextNode("Hello, World!");
        LightElementNode span = new LightElementNode("span", false, false, hooks);
        span.AddChild(new LightTextNode("This is a span."));

        CommandManager commandManager = new CommandManager();

        commandManager.ExecuteCommand(new AddElementCommand(div, textNode));
        commandManager.ExecuteCommand(new AddElementCommand(div, span));

        Console.WriteLine("After adding elements:");
        Console.WriteLine(div.OuterHtml);

        commandManager.Undo();

        Console.WriteLine("After undoing last command:");
        Console.WriteLine(div.OuterHtml);

        commandManager.ExecuteCommand(new AddElementCommand(div, span));

        Console.WriteLine("After re-adding span:");
        Console.WriteLine(div.OuterHtml);

        HtmlIterator iterator = new HtmlIterator(div);
        Console.WriteLine("Iterating through HTML document:");
        while (iterator.HasNext())
        {
            var node = iterator.Next();
            Console.WriteLine(node.OuterHtml);
        }

        Console.WriteLine("Initial state of div:");
        Console.WriteLine(div.GetState());
        div.SetState("Active");
        Console.WriteLine("State of div after activation:");
        Console.WriteLine(div.GetState());
        div.SetState("Inactive");
        Console.WriteLine("State of div after deactivation:");
        Console.WriteLine(div.GetState());

        Console.WriteLine("Visiting HTML document:");
        HtmlVisitor visitor = new HtmlVisitor();
        div.Accept(visitor);
    }
}