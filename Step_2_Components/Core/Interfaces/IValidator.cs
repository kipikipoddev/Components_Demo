namespace Components_Demo;

public interface IValidator<T> : IComponent
    where T : Command
{
    bool Is_Valid(T cmd);
}