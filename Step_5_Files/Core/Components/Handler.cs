
namespace Step_5_Files.Core;

public abstract class Handler<T> : Component, IHandler<T>
    where T : Command
{
    public abstract void Handle(T cmd);
}