
namespace Components_Solution;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);

    T Get<T>()
        where T : IComponent;

    IEnumerable<T> Get_All<T>()
        where T : IComponent;

    IEnumerable<IComponent> Get_All(Type type);

    bool Has<T>()
        where T : IComponent;
}