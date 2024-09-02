
namespace Components_Solution;

public abstract class Printer_Handler : Component, IHandler<Print_Command>
{
    protected abstract void Print(string message);
    public void Handle(Print_Command cmd)
    {
        if (cmd.Is_Success)
            Print($"{Parent.Name()} was {cmd.Action}");
        else
            Print($"{Parent.Name()} cannot {cmd.Action}");
    }
}