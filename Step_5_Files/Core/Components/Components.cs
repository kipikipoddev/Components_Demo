namespace Step_5_Files;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, List<IComponent>> components = new();

    public Components(params IComponent[] objects)
    {
        foreach (var obj in objects)
            Add(obj);
    }

    public void Add(IComponent? component, bool insert = false)
    {
        if (component == null)
            return;
        component.Parent = this;
        Add_Component(component, insert);
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

    private void Add_Component(IComponent component, bool insert)
    {
        var type = component.GetType();
        Add(component, type, insert);
        foreach (var int_type in type.GetInterfaces())
            Add(component, int_type, insert);
    }

    private void Add(IComponent component, Type type, bool insert)
    {
        if (!components.ContainsKey(type))
            components[type] = new();
        if (insert)
            components[type].Insert(0, component);
        else
            components[type].Add(component);
    }
}