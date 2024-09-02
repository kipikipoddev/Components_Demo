namespace Components_Solution;

public class Injure_Command : Action_Command
{
    public override string Name => "injure";
    public override string Did => "injured";

    public Injure_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
