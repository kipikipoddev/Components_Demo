
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

    public virtual void Send()
    {
        Handling_Mediator.Send(this);
    }
}