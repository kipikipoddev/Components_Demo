namespace Components_Solution;

public class Walk_Command : Action_Command
{
    public override string Name => "walk";
    public override string Did => "walked";

    public Walk_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
