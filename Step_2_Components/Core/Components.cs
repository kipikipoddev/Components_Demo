namespace Step_2_Components;

public class Components : Component, IComponents
{
    private readonly HashSet<IComponent> components = [];

    public IComponents Add(IComponent component)
    {
        components.Add(component);
        component.Parent = this;
        return this;
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components.First(Is_Type<T>);
    }

    private static bool Is_Type<T>(IComponent comp)
    {
        return comp.GetType().GetInterfaces().Contains(typeof(T));
    }
}