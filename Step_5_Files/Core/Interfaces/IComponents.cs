namespace Step_5_Files;

public interface IComponents : IComponent
{
    void Add(IComponent component, bool insert = false);

    T Get<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;

    IEnumerable<T> Get_All<T>()
        where T : IComponent;

    bool Can<T>()
        where T : Command;
}