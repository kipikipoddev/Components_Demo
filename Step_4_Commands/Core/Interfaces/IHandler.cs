namespace Step_4_Commands.Core;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}