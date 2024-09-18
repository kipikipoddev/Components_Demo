
namespace Step_5_Final;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);

    T Get<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;

    IEnumerable<IComponent> Get_All();
}