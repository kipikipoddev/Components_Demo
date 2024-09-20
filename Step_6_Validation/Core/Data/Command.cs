
namespace Step_6_Validation;

public abstract record Command
{
    public IComponents Components { get; }

    protected Command(IComponents components, bool auto_send = true)
    {
        Components = components;
        if (auto_send)
            Send();
    }

    public virtual bool Is_Valid()
    {
        return Mediator.Is_Valid(this);
    }

    public virtual bool Send()
    {
        var is_valid = Is_Valid();
        if (is_valid)
            Mediator.Send(this);
        return is_valid;
    }
}