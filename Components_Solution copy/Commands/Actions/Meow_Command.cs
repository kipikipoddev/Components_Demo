namespace Components_Solution;

public class Meow_Command : Action_Command
{
    public override Actions Name => Actions.Meow;
    public override Actions Did => Actions.Meowing;

    public Meow_Command(IComponents components)
        : base(components)
    {
    }
}
