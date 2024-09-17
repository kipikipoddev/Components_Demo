namespace Step_5_Complex;

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

    public bool Has<T>()
        where T : IComponent
    {
        return Get_All<T>().Any();
    }

    public void Remove<T>()
        where T : IComponent
    {
        components.Remove(Get<T>());
    }

    public void Remove(IComponent component)
    {
        components.Remove(component);
        Mediator.Remove(component);
    }

    private static bool Is_Type(IComponent comp, Type type)
    {
        return comp.GetType() == type || comp.GetType().GetInterfaces().Contains(type);
    }
}