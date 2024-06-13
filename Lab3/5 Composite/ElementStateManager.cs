using _5_Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
public class ElementStateManager
{
    private LightElementNode _element;
    private string _currentState;

    public ElementStateManager(LightElementNode element)
    {
        _element = element;
        _currentState = "Inactive";
    }

    public void SetState(string state)
    {
        _currentState = state;
        if (state == "Active")
        {
            _element.AddClass("active");
            Console.WriteLine($"{_element.TagName} is now active.");
        }
        else
        {
            _element.RemoveClass("active");
            Console.WriteLine($"{_element.TagName} is now inactive.");
        }
    }

    public string GetState()
    {
        return _currentState;
    }
}
}
