namespace Step_4_Files;

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
        return components.Where(Is_Type<T>).Select(c => (T)c);
    }

    private static bool Is_Type<T>(IComponent comp)
    {
        return comp.GetType().GetInterfaces().Contains(typeof(T));
    }
}