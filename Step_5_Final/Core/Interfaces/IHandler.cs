
namespace Step_5_Final;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}