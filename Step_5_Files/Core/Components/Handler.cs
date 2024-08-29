namespace Step_5_Files;

public abstract class Handler<T> : Component, IHandler<T>
    where T : Command
{
    public abstract void Handle(T cmd);
}