using _5_Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
public class CommandManager
{
    private Stack<Command> _commandHistory = new Stack<Command>();

    public void ExecuteCommand(Command command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void Undo()
    {
        if (_commandHistory.Count > 0)
        {
            Command command = _commandHistory.Pop();
            command.Undo();
        }
    }
}
}
