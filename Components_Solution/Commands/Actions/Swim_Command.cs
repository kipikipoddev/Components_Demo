namespace Components_Solution;

public class Swim_Command : Action_Command
{
    public override Actions Name => Actions.Swim;
    public override Actions Did => Actions.Swiming;

    public Swim_Command(IComponents components)
    : base(components)
    {
    }
}
