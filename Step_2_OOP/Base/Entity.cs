namespace Step_2_OOP;

public class Entity : IEntity
{
    protected IAction_Printer Printer { get; }
    public Speed Speed { get; }
    public string Name { get; set; }

    public Entity(IAction_Printer printer, Speed speed)
    {
        Printer = printer;
        Name = GetType().Name;
        Speed = speed;
    }

    public virtual IEnumerable<Actions> Actions_Possible
    {
        get
        {
            return [0];
        }
    }
}