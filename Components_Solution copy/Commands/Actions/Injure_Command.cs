namespace Components_Solution;

public class Injure_Command : Action_Command
{
    public override Actions Name => Actions.Injure;
    public override Actions Did => Actions.Injured;

    public Injure_Command(IComponents components)
        : base(components)
    {
    }
}
