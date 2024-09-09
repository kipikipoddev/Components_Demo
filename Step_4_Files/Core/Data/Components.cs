namespace Step_4_Files;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, IComponent> components = new();

    public IComponents Add(IComponent component)
    {
        components[component.GetType()] = component;
        foreach (var int_type in Get_Int_Types(component))
            components[int_type] = component;
        component.Parent = this;
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

    private static Type[] Get_Int_Types(IComponent component)
    {
        return component.GetType().GetInterfaces();
    }
}