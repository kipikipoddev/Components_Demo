namespace Components_Solution;

public class Charge_Command : Action_Command
{
    public override string Name => "charge";
    public override string Did => "charged";

    public Charge_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
