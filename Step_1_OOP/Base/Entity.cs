namespace Step_1_OOP;

public abstract class Entity : IEntity
{
    protected IAction_Printer Printer { get; }

    public Speed Speed { get; }
    public string Name { get; set; }
    public virtual bool Can_Swim { get; protected set; }
    public virtual bool Can_Make_Sound { get; protected set; }
    public virtual bool Can_Walk { get; protected set; }

    public Entity(IAction_Printer printer, Speed speed)
    {
        Printer = printer;
        Name = GetType().Name;
        Speed = speed;
    }

    public virtual void Make_Sound()
    {
        Printer.Print_Cannot(this, Actions.Make_Sound);
    }

    public virtual void Swim()
    {
        if (Can_Swim)
            Printer.Print_Action(this, Actions.Swiming, true);
        else
            Printer.Print_Cannot(this, Actions.Swim);
    }

    public virtual void Walk()
    {
        if (Can_Walk)
            Printer.Print_Action(this, Actions.Walking, true);
        else
            Printer.Print_Cannot(this, Actions.Walk);
    }
}