namespace Components_Better_Solution;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, List<IComponent>> components = new();

    public IComponents Add(IComponent component)
    {
        foreach (var int_type in Get_Types(component))
            Add(component, int_type);
        component.Set_Parent(this);
        return this;
    }

    public IComponents Add(params IComponent[] components)
    {
        foreach (var component in components)
            Add(component);
        return this;
    }

    public IComponents Add<T>(IComponent component)
    {
        Add(component, typeof(T));
        component.Set_Parent(this);
        return this;
    }

    public IComponents Remove(IComponent component)
    {
        foreach (var int_type in Get_Types(component))
            components[int_type].Remove(component);
        component.Set_Parent(null);
        return this;
    }

    public IComponents Remove<T>(IComponent component)
    {
        components[typeof(T)].Remove(component);
        return this;
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components[typeof(T)].First();
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
        return components.ContainsKey(typeof(T)) & components[typeof(T)].Any();
    }

    private void Add(IComponent component, Type type)
    {
        if (!components.ContainsKey(type))
            components[type] = [];
        components[type].Add(component);
    }

    private static Type[] Get_Types(IComponent component)
    {
        return component.GetType().GetInterfaces();
    }
}