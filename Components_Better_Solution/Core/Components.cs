namespace Components_Better_Solution;

public class Components : Component, IComponents
{
    private readonly Dictionary<Type, List<IComponent>> components = new();

    public IComponents Add(IComponent component)
    {
        var int_types = component.GetType().GetInterfaces();
        foreach (var int_type in int_types)
        {
            if (!components.ContainsKey(int_type))
                components[int_type] = [];
            components[int_type].Add(component);
        }
        component.Set_Parent(this);
        return this;
    }

    public T Get<T>()
        where T : IComponent
    {
        return (T)components[typeof(T)].First();
    }

    public IEnumerable<T> Get_All<T>()
        where T : IComponent
    {
        return components[typeof(T)].Select(c => (T)c);
    }

    public bool Has<T>() 
        where T : IComponent
    {
       return components.ContainsKey(typeof(T));
    }
}