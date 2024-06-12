using _3_Observer;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var div = new Div("container", "Hello, LightHTML!");
        var paragraph = new Paragraph("", "This is a paragraph inside a div.");
        var fileImage = new Image("local/path/to/image.png", new FileImageLoader());
        var networkImage = new Image("http://example.com/image.png", new NetworkImageLoader());

        var clickListener = new EventListener("ClickListener");
        var mouseoverListener = new EventListener("MouseoverListener");

        div.AddEventListener("click", clickListener);
        div.AddEventListener("mouseover", mouseoverListener);

        paragraph.AddEventListener("click", clickListener);
        paragraph.AddEventListener("mouseover", mouseoverListener);

        fileImage.AddEventListener("click", clickListener);
        fileImage.AddEventListener("mouseover", mouseoverListener);

        networkImage.AddEventListener("click", clickListener);
        networkImage.AddEventListener("mouseover", mouseoverListener);

        div.Render();
        paragraph.Render();
        fileImage.Render();
        networkImage.Render();

        Console.WriteLine("\nSimulating events:");
        div.Click();
        div.MouseOver();
        paragraph.Click();
        paragraph.MouseOver();
        fileImage.Click();
        fileImage.MouseOver();
        networkImage.Click();
        networkImage.MouseOver();
    }
}