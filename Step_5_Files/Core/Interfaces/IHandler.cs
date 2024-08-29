namespace Step_5_Files;

public interface IHandler<T> : IComponent
    where T : Command
{
    void Handle(T cmd);
}