namespace Step_5_Files.Core;

public record Event
{
    public object? Object { get; private set; }

    public Event(object? @object = null, bool auto_send = true)
    {
        Object = @object;
        if (auto_send)
            Send();
    }

    public virtual void Send()
    {
        Mediator.Send(this);
    }
}