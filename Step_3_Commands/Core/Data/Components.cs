namespace Step_3_Commands;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, IComponent> components = [];

    public IComponents Add(IComponent component)
    {
        var type = component.GetType();
        components[type] = component;
        foreach (var int_type in type.GetInterfaces())
            components[int_type] = component;
        component.Parent = this;
        return this;
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components[typeof(T)];
    }

    public bool Has<T>()
        where T : IComponent
    {
        return components.ContainsKey(typeof(T));
    }
}