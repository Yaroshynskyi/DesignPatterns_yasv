using System.Text;
using _5_Composite;
namespace _6_lightweight;

class Program
{
    static void Main(string[] args)
    {
        long startMemory = GC.GetTotalMemory(true);

        string text = "THE MYSTERY OF THE FORGOTTEN TOMB\n\nby Jane Doe\n\n\n\n\nContents\n\nPROLOGUE.\n\nCHAPTER I\nScene I. The Haunted House.\nScene II. The Secret Passage.\nScene III. The Cryptic Clue.\nScene IV. The Hidden Chamber.\nScene V. The Decoding Device.\n\nCHAPTER II\nScene I. The Enchanted Forest.\nScene II. The Talking Tree.\nScene III. The Magical Spring.\nScene IV. The Guardian Dragon.\nScene V. The Sorcerer's Spell.\nScene VI. The Final Confrontation.\n\nCHAPTER III\nScene I. The Lost City.\nScene II. The Ancient Temple.\nScene III. The Sacred Artifact.\nScene IV. The Treacherous Trap.\nScene V. The Hero's Sacrifice.\n\nEPILOGUE\n\n\n Enter Narrator.\n\nNARRATOR.\nIn a world shrouded in mystery and magic,\nWhere ancient secrets lie hidden and untold,\nBrave souls embark on a quest of discovery,\nTo unravel the enigma of the forgotten tomb.\nThrough perilous trials and unexpected allies,\nThey journey towards the truth that awaits,\nAnd in the end, they find not just answers,\nBut the courage and wisdom to face the unknown.\n\n [_Exit._]\n";
        string[] lines = text.Split('\n');

        LightElementNode root = new LightElementNode("div", true, false);

        //LightTextNode spaceNode = new LightTextNode(" ");

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            LightElementNode node;

            if (i == 0)
            {
                node = new LightElementNode("h1", false, false);
            }
            else if (line.StartsWith(" "))
            {
                node = new LightElementNode("blockquote", false, false);
                //node.AddChild(spaceNode);  // use the flyweight 
            }
            else if (line.Length < 20)
            {
                node = new LightElementNode("h2", false, false);
            }
            else
            {
                node = new LightElementNode("p", false, false);
            }

            node.AddChild(new LightTextNode(line.Trim()));
            root.AddChild(node);
        }

        Console.WriteLine(root.OuterHtml);

        long endMemory = GC.GetTotalMemory(true);
        long usedMemory = endMemory - startMemory;
        Console.WriteLine($"Використано пам'яті: {usedMemory} байт");
    }
}
