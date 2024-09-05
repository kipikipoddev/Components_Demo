
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
        return Validation_Mediator.Is_Valid(this);
    }

    public virtual bool Send()
    {
        var is_valid = Validation_Mediator.Is_Valid(this);
        if (is_valid)
            Handling_Mediator.Send(this);
        return is_valid;
    }
}