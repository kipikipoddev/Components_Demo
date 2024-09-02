namespace Components_Solution;

public class Swim_Command : Action_Command
{
    public override string Name => "swim";
    public override string Did => "swimming";

    public Swim_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
