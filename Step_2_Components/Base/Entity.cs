
namespace Components_Demo;

public class Entity : IEntity
{
    public string Name { get; }

    public Speed Speed { get; }

    public IAction[] Actions { get; }

    public Entity(string? name = null)
    {
        Name = name ?? GetType().Name;
    }
}