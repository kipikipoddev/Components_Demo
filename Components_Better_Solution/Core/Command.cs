
namespace Components_Better_Solution;

public class Command
{
    public IComponents Components { get; }

    public Command(IComponents components)
    {
        Components = components;
    }

    public virtual bool Is_Valid()
    {
        return true;
    }

    protected virtual void Send<T>(T cmd)
        where T : Command
    {
        Mediator.Send(cmd);
    }
}