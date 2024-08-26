namespace Step_4_Mediator.Core;

public record Command : Event
{
    public IComponent Component => (IComponent)Object;
    public IComponents Components => (IComponents)Object;

    public Command(IComponent component, bool auto_send = true)
        :base(component, auto_send)
    {
    }
}
