namespace Components_Basic_Solution;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, IComponent> components = new();

    public IComponents Add(IComponent component)
    {
        components[component.GetType()] = component;
        component.Set_Parent(this);
        return this;
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components[typeof(T)];
    }
}