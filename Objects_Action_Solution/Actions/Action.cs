namespace Objects_Solution;

public abstract class Action : IAction
{
    private readonly IAction_Printer printer;
    private readonly IEntity Entity;

    protected abstract Actions Name { get; }
    protected abstract Actions Cannot { get; }

    public Action(IAction_Printer printer, IEntity entity)
    {
        this.printer = printer;
        Entity = entity;
    }

    public virtual void Do()
    {
        printer.Print_Action(Entity, Name);
    }
}