using Step_4_Mediator.Core;

namespace Step_4_Mediator.Sound_Handlers;

public abstract class Handler<T> : Component, IHandler<T>
    where T : Command
{
    protected override void Parent_Set()
    {
        Mediator.Add(this, Parent);
    }

    public abstract void Handle(T cmd);
}