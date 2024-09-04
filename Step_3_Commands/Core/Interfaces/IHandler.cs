
namespace Step_3_Commands;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}