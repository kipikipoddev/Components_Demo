namespace Step_3_Components;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, IComponent> components = new();

    public Components(params IComponent[] objects)
    {
        foreach (var obj in objects)
            Add(obj);
    }

    public IComponents Add(IComponent component)
    {
        component.Parent = this;
        Add_Component(component);
        return this;
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components[typeof(T)];
    }

    public T? Get_Or_Default<T>()
        where T : IComponent
    {
        if (components.ContainsKey(typeof(T)))
            return Get<T>();
        return default;
    }

    private void Add_Component(IComponent component)
    {
        var type = component.GetType();
        components[type] = component;
        foreach (var interface_type in type.GetInterfaces())
            components[interface_type] = component;
    }
}