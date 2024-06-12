using _5_Composite;

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


    }
}