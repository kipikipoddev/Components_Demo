namespace Step_3_Commands;

public class Action_Component<T> : Component, IHandler<T>
    where T : Action_Command
{
    public virtual void Handle(T cmd)
    {
        Print(cmd.Action);
    }

    protected void Print(Actions action)
    {
        new Print_Command(Parent, action, true);
    }
}