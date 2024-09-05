namespace Step_5_Complex;

public class Action_Component<T> : Component, IHandler<T>
    where T : Action_Command
{
    public virtual void Handle(T cmd)
    {
        Handle((Action_Command)cmd);
    }

    protected virtual void Handle(Action_Command cmd)
    {
        new Print_Command(Parent, cmd.Was, true);
    }
}