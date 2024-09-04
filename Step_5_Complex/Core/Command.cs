
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
        return Mediator.Is_Valid(this);
    }

    public virtual void Send()
    {
        Mediator.Send(this);
    }
}