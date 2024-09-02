namespace Components_Solution;

[Action(Actions.Walk, Actions.Walking)]
public class Walk_Command : Action_Command
{
    public Walk_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
