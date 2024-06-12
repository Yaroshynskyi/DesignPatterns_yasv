using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Observer
{
    public class Image : HTMLElement
    {
        public string Src { get; set; }
        private readonly IImageLoader _imageLoader;

        public Image(string src, IImageLoader imageLoader)
        {
            Src = src;
            _imageLoader = imageLoader;
        }

        public override void Render()
        {
            Console.WriteLine($"<img src=\"{Src}\" />");
            _imageLoader.Load(Src);
        }

        public void Click()
        {
            Console.WriteLine($"Image with src '{Src}' was clicked.");
            Notify("click");
        }
        public void MouseOver()
        {
            Console.WriteLine($"Mouse over Image with src '{Src}'.");
            Notify("mouseover");
        }
    }
}
