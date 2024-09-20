
namespace Step_5_Actions;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);

    T Get<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;

    IEnumerable<T> Get_All<T>();
}