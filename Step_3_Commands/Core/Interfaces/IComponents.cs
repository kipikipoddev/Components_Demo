
namespace Step_3_Commands;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);

    T Get<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;
}