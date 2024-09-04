
namespace Step_4_Files;

public interface IValidator<T> : IComponent
    where T : Command
{
    bool Is_Valid(T cmd);
}