namespace Components_Solution;

public class Charge_Command : Action_Command
{
    public override Actions Name => Actions.Charge;
    public override Actions Did => Actions.Charged;
    public Charge_Command(IComponents components)
        : base(components)
    {
    }
}
