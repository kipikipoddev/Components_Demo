namespace Components_Solution;

public interface IValidator<T> : IComponent
    where T : Command
{
    bool Is_Valid(T cmd);
}