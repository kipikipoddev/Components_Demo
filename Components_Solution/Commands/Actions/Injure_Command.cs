namespace Components_Solution;

[Action(Actions.Injure, Actions.Injured)]
public class Injure_Command : Action_Command
{
    public Injure_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
