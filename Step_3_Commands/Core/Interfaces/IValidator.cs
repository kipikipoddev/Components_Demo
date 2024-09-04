
namespace Step_3_Commands;

public interface IValidator<T> : IComponent
    where T : Command
{
    bool Is_Valid(T cmd);
}