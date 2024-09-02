namespace Components_Solution;

[Action(Actions.Charge, Actions.Charged)]
public class Charge_Command : Action_Command
{
    public Charge_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
