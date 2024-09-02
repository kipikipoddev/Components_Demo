namespace Objects_Solution;

public class Bark_Action : Action
{
    protected override Actions Name => Actions.Barking;
    protected override Actions Cannot => Actions.Bark;
    public Bark_Action(IAction_Printer printer, IEntity entity)
        : base(printer, entity)
    {
    }
}