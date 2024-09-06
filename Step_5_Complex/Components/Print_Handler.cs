
namespace Step_5_Complex;

public abstract class Print_Handler
    : Component, IHandler<Print_Action_Command>, IHandler<Print_Cant_Command>
{
    protected abstract void Print(string message);

    public void Handle(Print_Action_Command cmd)
    {
        Print("was", (Actions_Description)cmd.Action);
    }

    public void Handle(Print_Cant_Command cmd)
    {
        Print("can't", cmd.Action);
    }

    private void Print(string middle, object action, object? extra = null)
    {
        var name = Parent.Get<IName_Component>().Name;
        var action_str = action.ToString()!.ToLower();
        Print($"{name} {middle} {action_str}{extra ?? ""}");
    }
}