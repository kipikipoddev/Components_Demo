namespace Components_Demo;

public interface IHandler<T> : IComponent
    where T : Command
{
    bool Is_Valid(T cmd) => true;
    void Handle(T cmd);
}