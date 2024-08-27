using Step_5_Files.Interfaces;

namespace Step_5_Files.Core;

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