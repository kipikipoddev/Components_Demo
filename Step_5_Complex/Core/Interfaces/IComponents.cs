
namespace Step_5_Complex;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);

    T Get<T>()
        where T : IComponent;
        
    IEnumerable<T> Get_All<T>()
        where T : IComponent;

    bool Has<T>()
        where T : IComponent;

    void Remove<T>()
         where T : IComponent;
}