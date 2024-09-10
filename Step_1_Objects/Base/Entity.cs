
namespace Step_1_Objects;

public abstract class Entity : IEntity
{
    protected IAction_Printer Printer { get; }

    public string Name { get; set; }
    public abstract IEnumerable<Actions> Available_Actions { get; }

    public Entity(IAction_Printer printer, string name)
    {
        Printer = printer;
        Name = name;
    }
}