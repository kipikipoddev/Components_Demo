namespace Step_4_Commands;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}