namespace Step_5_Final;

public abstract class Print_Component : Component, IHandler<Print_Was_Command>, IHandler<Print_Cant_Command>
{
    public Print_Component()
    {
        Mediator.Add_Handler<Print_Was_Command>(this);
        Mediator.Add_Handler<Print_Cant_Command>(this);
    }

    public void Handle(Print_Was_Command cmd)
    {
        Print("was", cmd.Action);
    }

    public void Handle(Print_Cant_Command cmd)
    {
        Print("can't", cmd.Action);
    }

    protected abstract void Print(string message);

    private void Print(string middle, object action)
    {
        var name = Parent.Get<IName_Component>().Name;
        var action_str = action.ToString()!.ToLower();
        Print($"{name} {middle} {action_str}");
    }

}