using Step_4_Mediator.Interfaces;

namespace Step_4_Mediator.Core;

public class Component : IComponent
{
    private IComponents parent;
    public IComponents Parent
    {
        get => parent;
        set
        {
            parent = value;
            Parent_Set();
        }
    }

    public void Write(string message)
    {
        Console.WriteLine($"{Parent.Name()} is {message}");
    }

    protected virtual void Parent_Set() { }
}