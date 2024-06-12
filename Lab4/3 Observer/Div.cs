using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Observer
{
    public class Div : HTMLElement
    {
        public string Class { get; set; }
        public string Content { get; set; }

        public Div(string @class, string content)
        {
            Class = @class;
            Content = content;
        }

        public override void Render()
        {
            Console.WriteLine($"<div class=\"{Class}\">{Content}</div>");
        }

        // Імітація події click
        public void Click()
        {
            Console.WriteLine($"Div with class '{Class}' was clicked.");
            Notify("click");
        }

        // Імітація події mouseover
        public void MouseOver()
        {
            Console.WriteLine($"Mouse over Div with class '{Class}'.");
            Notify("mouseover");
        }
    }


}
