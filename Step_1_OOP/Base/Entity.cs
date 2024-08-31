namespace Step_1_OOP;

public abstract class Entity : IEntity
{
    protected IAction_Printer Printer { get; }

    public Speed Speed { get; }
    public string Name { get; set; }
    public abstract bool Can_Swim { get; }
    public abstract bool Can_Walk { get; }

    public Entity(IAction_Printer printer, Speed speed)
    {
        Printer = printer;
        Name = GetType().Name;
        Speed = speed;
    }

    public virtual void Swim()
    {
        if (Can_Swim)
            Printer.Print_Action(this, Actions.Swiming, Speed);
        else
            Printer.Print_Cannot(this, Actions.Swim);
    }

    public virtual void Walk()
    {
        if (Can_Walk)
            Printer.Print_Action(this, Actions.Walking, Speed);
        else
            Printer.Print_Cannot(this, Actions.Walk);
    }

    public virtual IEnumerable<Actions> Get_Actions()
    {
        if (Can_Walk)
            yield return Actions.Walk;
        if (Can_Swim)
            yield return Actions.Swim;
    }
}