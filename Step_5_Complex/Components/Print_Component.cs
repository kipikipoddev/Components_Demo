
namespace Step_5_Complex;

public abstract class Print_Component
    : Component, IHandler<Print_Action_Command>
{
    protected abstract void Print(string message);

    public Print_Component()
    {
        Mediator.Add_Handler(this);
    }

    public void Handle(Print_Action_Command cmd)
    {
        var extra = Get_Extra(cmd);
        if (cmd.Is_Was)
            Print("was", (Actions_Description)cmd.Action, extra);
        else
            Print("can't", cmd.Action, extra);
    }

    private void Print(string middle, object action, object? extra = null)
    {
        var name = Parent.Get<IName_Component>().Name;
        var action_str = action.ToString().ToLower();
        var extra_str = extra != null ? " " + extra.ToString().ToLower() : string.Empty;
        Print($"{name} {middle} {action_str}{extra_str}");
    }

    private static object? Get_Extra(Print_Action_Command cmd)
    {
        return cmd.Speed != null ? (Speed_Description)cmd.Speed :
            cmd.Volume != null ? (Volume_Description)cmd.Volume : null;
    }
}