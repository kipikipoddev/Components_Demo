
namespace Step_5_Complex;

public abstract class Command
{
    public IComponents Components { get; }

    public Command(IComponents components)
    {
        Components = components;
    }

    public virtual bool Is_Valid()
    {
        return Mediator.Validate(this);
    }

    public virtual bool Send()
    {
        var is_valid = Is_Valid();
        if (is_valid)
            Mediator.Send(this);
        return is_valid;
    }
}