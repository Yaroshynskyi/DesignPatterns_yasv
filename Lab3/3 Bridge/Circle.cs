using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Bridge
{
    class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            renderer.Render("Drawing Circle");
        }
    }
}
