namespace Components_Demo;

public abstract class Entity : IEntity
{
    protected IAction_Printer Printer { get; }

    public string Name { get; set; }

    public Entity(IAction_Printer printer)
    {
        Printer = printer;
        Name = GetType().Name;
    }

    public abstract IEnumerable<Actions> Get_Actions();
}