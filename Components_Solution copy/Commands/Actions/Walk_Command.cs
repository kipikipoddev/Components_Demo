namespace Components_Solution;

public class Walk_Command : Action_Command
{
    public override Actions Name => Actions.Walk;
    public override Actions Did => Actions.Walking;

    public Walk_Command(IComponents components)
        : base(components)
    {
    }
}
