namespace Step_5_Complex;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, HashSet<IComponent>> components = [];

    public IComponents Add(IComponent component)
    {
        foreach (var type in Get_Types(component.GetType()))
            Add(component, type);
        component.Parent = this;
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
        return components.ContainsKey(typeof(T)) && components[typeof(T)].Any();
    }

    public void Remove<T>()
        where T : IComponent
    {
        foreach (var component in Get_All<T>().ToArray())
        {
            foreach (var type in components.Keys)
            {
                components[type].Remove(component);
                if (!components[type].Any())
                    components.Remove(type);
            }
            Mediator.Remove(component);
        }
    }

    private void Add(IComponent component, Type type)
    {
        if (!components.ContainsKey(type))
            components[type] = [];
        components[type].Add(component);
    }

    private static IEnumerable<Type> Get_Types(Type? type)
    {
        if (type == null)
            yield break;
        yield return type;
        foreach (var base_type in Get_Types(type.BaseType))
            yield return base_type;
        foreach (var int_type in type.GetInterfaces())
            yield return int_type;
    }
}