
namespace Step_5_Final;

public interface IValidator<T> : IComponent
    where T : Command
{
    bool Is_Valid(T cmd);
}