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
        return Get_All<T>().First();
    }

    public IEnumerable<T> Get_All<T>()
        where T : IComponent
    {
        return components.Where(c => Is_Type(c, typeof(T))).Select(c => (T)c);
    }
    
    private static bool Is_Type(IComponent comp, Type type)
    {
        return comp.GetType() == type || comp.GetType().GetInterfaces().Contains(type);
    }
}