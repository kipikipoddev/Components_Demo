namespace Components_Solution;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd, Action next);
}