
namespace Step_5_Actions;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}