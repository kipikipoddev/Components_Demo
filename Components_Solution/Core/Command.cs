namespace Components_Solution;

public abstract class Command
{
    public IComponents Components { get; }

    public Command(IComponents components)
    {
        Components = components;
    }

    public void Send()
    {
        Mediator.Send(this);
    }

    public bool Is_Valid()
    {
        return Mediator.Is_Valid(this);
    }
}
