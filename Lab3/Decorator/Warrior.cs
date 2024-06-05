using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Warrior : Hero
    {
        public Warrior(string name, int level) : base(name, level) { }
    }

}
