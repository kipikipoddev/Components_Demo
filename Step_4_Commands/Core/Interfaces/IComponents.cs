namespace Step_4_Commands.Core;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);

    T Get<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;

    IEnumerable<T> Get_All<T>()
        where T : IComponent;

    bool Can<T>()
        where T : Command;
}