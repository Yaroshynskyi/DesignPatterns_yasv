using _4_Prototype;
using System;

class Program
{
    static void Main()
    {
        // Створення вірусів
        Virus parentVirus = new Virus(1.5, 5, "ParentVirus", "Influenza");
        Virus childVirus1 = new Virus(0.8, 2, "ChildVirus1", "Influenza");
        Virus childVirus2 = new Virus(1.0, 3, "ChildVirus2", "Influenza");

        // Додавання дітей до батьківського вірусу
        parentVirus.AddChild(childVirus1);
        parentVirus.AddChild(childVirus2);

        // Клонування вірусів
        Virus clonedParent = (Virus)parentVirus.Clone();
        Virus clonedChild1 = (Virus)childVirus1.Clone();

        // Відображення даних клонованих вірусів
        Console.WriteLine("Cloned Parent Virus:");
        clonedParent.Display();

        Console.WriteLine("Cloned Child Virus 1:");
        clonedChild1.Display();

        Console.WriteLine("Cloned Child Virus 2:");
        foreach (var child in clonedParent.Children)
        {
            child.Display();
        }
    }
}