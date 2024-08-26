namespace Step_4_Mediator.Core;

public record Command : Event
{
    public IComponents Components => (IComponents)Object!;

    public Command(IComponents components, bool auto_send = true)
        :base(components, auto_send)
    {
    }
}