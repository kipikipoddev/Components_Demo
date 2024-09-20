
namespace Step_6_Validation;

public interface IValidator<T> : IComponent
    where T : Command
{
    bool Is_Valid(T cmd);
}