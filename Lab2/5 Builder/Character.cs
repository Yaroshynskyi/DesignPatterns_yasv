using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder
{
    public abstract class Character
    {
        public string Type { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public string Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public List<string> Inventory { get; }

        public Character()
        {
            Inventory = new List<string>();
        }

        public virtual void Display()
        {
            Console.WriteLine($"Тип: {Type}");
            Console.WriteLine($"Здоров'я: {Health}");
            Console.WriteLine($"Сила: {Strength}");
            Console.WriteLine($"Захист: {Defense}");
            Console.WriteLine($"Зріст: {Height}");
            Console.WriteLine($"Колір волосся: {HairColor}");
            Console.WriteLine($"Колір очей: {EyeColor}");
            Console.WriteLine("Інвентар:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
