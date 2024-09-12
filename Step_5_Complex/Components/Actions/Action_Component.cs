
namespace Step_5_Complex;

public abstract class Action_Component<T> : Component, IHandler<T>, IAction_Component
    where T : Action_Command
{
    public Action_Component()
    {
        Mediator.Add_Handler(this);
    }

    public abstract IEnumerable<Actions> Actions_Handling { get; }

    public virtual void Handle(T cmd)
    {
        Print(cmd);
    }

    protected void Print(Action_Command cmd)
    {
        new Print_Action_Command(Parent, cmd.Action, true);
    }
}