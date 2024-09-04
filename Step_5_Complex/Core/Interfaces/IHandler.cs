
namespace Step_5_Complex;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}