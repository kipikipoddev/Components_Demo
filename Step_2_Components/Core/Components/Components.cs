namespace Components_Demo;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, List<IComponent>> components = new();

    public IComponents Add(IComponent component)
    {
        var type = component.GetType();
        Add(component, type);
        foreach (var t in type.GetInterfaces())
            Add(component, t);
        return this;
    }

    public T Get<T>()
        where T : IComponent
    {
        if (components.ContainsKey(typeof(T)))
            return (T)components[typeof(T)].First();
        return default;
    }

    public IEnumerable<T> Get_All<T>()
        where T : IComponent
    {
        if (components.ContainsKey(typeof(T)))
            return components[typeof(T)].Select(c => (T)c);
        return [];
    }

    public bool Has<T>()
        where T : IComponent
    {
        return components.ContainsKey(typeof(T));
    }

    private void Add(IComponent component, Type type)
    {
        if (!components.ContainsKey(type))
            components[type] = new();
        components[type].Add(component);
        component.Set_Parent(this);
    }
}