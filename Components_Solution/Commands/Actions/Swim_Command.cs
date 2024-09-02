namespace Components_Solution;

[Action(Actions.Swim, Actions.Swiming)]
public class Swim_Command : Action_Command
{
    public Swim_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
