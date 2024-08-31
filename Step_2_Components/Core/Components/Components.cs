

namespace Components_Demo;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, List<IComponent>> components = new();

    public void Add<T>(IComponent component)
        where T : IComponent
    {
        var type = typeof(T);
        if (!components.ContainsKey(type))
            components[type] = new();
        components[type].Add(component);
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
}