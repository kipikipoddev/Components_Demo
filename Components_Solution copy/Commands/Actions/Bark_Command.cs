namespace Components_Solution;

public class Bark_Command : Action_Command
{
    public override Actions Name => Actions.Bark;
    public override Actions Did => Actions.Barking;

    public Bark_Command(IComponents components)
        : base(components)
    {
    }
}
