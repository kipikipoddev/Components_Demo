namespace Step_3_Components;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, IComponent> components = new();

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
        return (T)components[typeof(T)];
    }

    public T? Get_Or_Defualt<T>() where T : IComponent
    {
        return Has<T>() ? Get<T>() : default;
    }

    public bool Has<T>() where T : IComponent
    {
        return components.ContainsKey(typeof(T));
    }

    private void Add_Component(IComponent component)
    {
        var type = component.GetType();
        components[type] = component;
        foreach (var interface_type in type.GetInterfaces())
            components[interface_type] = component;
    }
}