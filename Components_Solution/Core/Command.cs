namespace Components_Solution;

public abstract class Command
{
    public IComponents Components { get; }

    public Command(IComponents components)
    {
        Components = components;
    }

    public static void Send<T>(T cmd)
        where T : Command
    {
        Mediator.Send(cmd);
    }

    public static bool Is_Valid<T>(T cmd)
        where T : Command
    {
        return Mediator.Is_Valid(cmd);
    }
}
