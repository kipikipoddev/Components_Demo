namespace Step_5_Files.Core;

public interface IComponents : IComponent
{
    IComponents Add(IComponent component);

    T Get<T>()
        where T : IComponent;
    T? Get_Or_Default<T>()
        where T : IComponent;
}