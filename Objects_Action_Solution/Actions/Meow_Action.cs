namespace Objects_Solution;

public class Meow_Action : Action
{
    protected override Actions Name => Actions.Meowing;
    protected override Actions Cannot => Actions.Meow;
    public Meow_Action(IAction_Printer printer, IEntity entity, Func<bool> can)
        : base(printer, entity, can)
    {
    }
}