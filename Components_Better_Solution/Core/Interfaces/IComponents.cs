
namespace Components_Better_Solution;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);
    IComponents Remove(IComponent component);

    T Get<T>()
        where T : IComponent;

    IEnumerable<T> Get_All<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;
}