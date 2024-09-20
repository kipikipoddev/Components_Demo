
namespace Step_6_Validation;

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

    public bool Has<T>() where T : IComponent
    {
        return components.FirstOrDefault(Is_Type<T>) != null;
    }

    public IEnumerable<T> Get_All<T>()
    {
        return components.Where(Is_Type<T>).Select(c => (T)c); ;
    }
}