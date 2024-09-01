
namespace Components_Demo;

public abstract class Printer_Component : Component, IPrinter_Component
{
    protected abstract void Print(string message);

    public void Print_Action(string action)
    {
        Print($"{Parent.Name()} was {action}");
    }

    public void Print_Cannot(string action)
    {
        Print($"{Parent.Name()} cannot {action}");
    }
}