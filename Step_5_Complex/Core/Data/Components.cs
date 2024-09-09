namespace Step_5_Complex;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, IComponent> components = new();

    public IComponents Add(IComponent component)
    {
        components[component.GetType()] = component;
        foreach (var int_type in Get_Int_Types(component))
            components[int_type] = component;
        component.Set_Parent(this);
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

    public void Remove<T>() where T : IComponent
    {
        var type = typeof(T);
        if (components.ContainsKey(type))
        {
            Mediator.Remove(components[type]);
            components[type].Remove();
            components.Remove(type);
        }
    }
    private static Type[] Get_Int_Types(IComponent component)
    {
        return component.GetType().GetInterfaces();
    }
}