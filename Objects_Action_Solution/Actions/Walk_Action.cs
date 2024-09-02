namespace Objects_Solution;

public class Walk_Action : Action
{
    protected override Actions Name => Actions.Walking;
    protected override Actions Cannot => Actions.Walk;
    public Walk_Action(IAction_Printer printer, IEntity entity, Func<bool> can)
        : base(printer, entity, can)
    {
    }
}