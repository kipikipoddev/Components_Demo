namespace Step_4_Commands;

public abstract class Handler<T> : Component, IHandler<T>
    where T : Command
{
    public abstract void Handle(T cmd);
}