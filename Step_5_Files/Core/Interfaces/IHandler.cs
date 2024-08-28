namespace Step_5_Files.Core;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}