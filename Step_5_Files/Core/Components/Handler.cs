using Step_5_Files.Core;

namespace Step_5_Files.Sound_Handlers;

public abstract class Handler<T> : Component, IHandler<T>
    where T : Command
{
    protected override void Parent_Set()
    {
        Mediator.Add(this, Parent);
    }

    public abstract void Handle(T cmd);
}