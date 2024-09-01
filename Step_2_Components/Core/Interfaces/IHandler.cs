namespace Components_Demo;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}