using System.Reflection;

namespace Components_Basic_Solution;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, IComponent> components = new();

    public IComponents Add(IComponent component)
    {
        var int_types = component.GetType().GetInterfaces();
        foreach (var int_type in int_types)
            components[int_type] = component;
        component.Set_Parent(this);
        return this;
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components[typeof(T)];
    }
}