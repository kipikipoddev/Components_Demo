
namespace Components_Demo;

public interface IComponents : IComponent
{
    void Add<T>(IComponent component)
        where T : IComponent;

    T Get<T>()
        where T : IComponent;

    IEnumerable<T> Get_All<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;
}