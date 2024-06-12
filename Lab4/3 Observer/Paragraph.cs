using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Observer
{
    public class Paragraph : HTMLElement
    {
        public string Class { get; set; }
        public string Content { get; set; }

        public Paragraph(string @class, string content)
        {
            Class = @class;
            Content = content;
        }

        public override void Render()
        {
            Console.WriteLine($"<p class=\"{Class}\">{Content}</p>");
        }

        // Імітація події click
        public void Click()
        {
            Console.WriteLine($"Paragraph with class '{Class}' was clicked.");
            Notify("click");
        }

        // Імітація події mouseover
        public void MouseOver()
        {
            Console.WriteLine($"Mouse over Paragraph with class '{Class}'.");
            Notify("mouseover");
        }
    }
}
