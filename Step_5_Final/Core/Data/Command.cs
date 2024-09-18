
namespace Step_5_Final;

public abstract record Command
{
    public IComponents Components { get; }
    protected Command(IComponents components)
    {
        Components = components;
        Mediator.Send(this);
    }
}