using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Prototype
{

    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            return new Virus(Weight, Age, Name, Type)
            {
                Children = new List<Virus>(Children)
            };
        }

        public void Display()
        {
            Console.WriteLine($"Virus: {Name}, Type: {Type}, Weight: {Weight}, Age: {Age}");
        }
    }
}
