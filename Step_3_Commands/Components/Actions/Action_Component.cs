namespace Step_3_Commands;

public class Action_Component<T> : Component, IHandler<T>
    where T : Action_Command
{
    public Action_Component()
    {
        Mediator.Add_Handler(this);
    }

    public virtual void Handle(T cmd)
    {
        Print(cmd);
    }

    protected void Print(Action_Command cmd)
    {
        new Print_Command(Parent, cmd.Action, true);
    }
}