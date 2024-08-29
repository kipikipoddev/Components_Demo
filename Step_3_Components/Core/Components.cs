namespace Step_3_Components;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, IComponent> components = new();

    public void Add(IComponent component)
    {
        component.Parent = this;
        foreach (var type in Get_Types(component))
            components[type] = component;
    }

    public void Remove<T>()
        where T : IComponent
    {
        foreach (var type in components.Keys)
            if (type.IsAssignableFrom(typeof(T)))
                components.Remove(type);
    }

    public void Remove(IComponent component)
    {
        foreach (var type in Get_Types(component))
            components.Remove(type);
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components[typeof(T)];
    }

    public T? Get_Or_Defualt<T>()
        where T : IComponent
    {
        return Has<T>() ?
            Get<T>() :
            default;
    }

    public bool Has<T>() where T : IComponent
    {
        return components.ContainsKey(typeof(T));
    }

    private IEnumerable<Type> Get_Types(IComponent component)
    {
        var type = component.GetType();
        yield return type;
        foreach (var interface_type in type.GetInterfaces())
            yield return interface_type;
    }
}