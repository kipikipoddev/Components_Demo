namespace Step_4_Commands;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, List<IComponent>> components = new();

    public Components(params IComponent[] objects)
    {
        foreach (var obj in objects)
            Add(obj);
    }

    public void Add(IComponent component)
    {
        component.Parent = this;
        Add_Component(component);
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components[typeof(T)].First();
    }

    public bool Has<T>() where T : IComponent
    {
        return components.ContainsKey(typeof(T));
    }

    public IEnumerable<T> Get_All<T>()
        where T : IComponent
    {
        if (!components.ContainsKey(typeof(T)))
            return [];
        return components[typeof(T)].Select(c => (T)c);
    }

    public bool Can<T>() 
        where T : Command
    {
        return Has<IHandler<T>>();
    }

    private void Add_Component(IComponent component)
    {
        var type = component.GetType();
        Add(component, type);
        foreach (var int_type in type.GetInterfaces())
            Add(component, int_type);
    }

    private void Add(IComponent component, Type type)
    {
        if (!components.ContainsKey(type))
            components[type] = new();
        components[type].Add(component);
    }
}