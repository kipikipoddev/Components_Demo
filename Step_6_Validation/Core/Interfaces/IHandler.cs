
namespace Step_6_Validation;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}