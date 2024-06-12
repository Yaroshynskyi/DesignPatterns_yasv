using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Memento
{
    public class TextEditor
    {
        private TextDocument _document;
        private readonly Stack<DocumentMemento> _history = new Stack<DocumentMemento>();
        private readonly List<string> _changeLog = new List<string>();

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public void Write(string newText)
        {
            _history.Push(new DocumentMemento(_document.Content));
            _document.Content += newText;
            _changeLog.Add($"Added: \"{newText}\"");
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _changeLog.Add($"Undo to: \"{memento.GetContent()}\"");
                _document.Content = memento.GetContent();
            }
            else
            {
                Console.WriteLine("No changes to undo.");
            }
        }

        public void Print()
        {
            Console.WriteLine(_document);
        }

        public void PrintChangeLog()
        {
            Console.WriteLine("Change Log:");
            foreach (var log in _changeLog)
            {
                Console.WriteLine(log);
            }
        }
    }
}
