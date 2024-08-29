namespace Step_3_Components;

public interface IComponents : IComponent
{
    void Add(IComponent component);

    void Remove<T>()
         where T : IComponent;

    void Remove(IComponent component);

    T Get<T>()
        where T : IComponent;

    T? Get_Or_Defualt<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;
}