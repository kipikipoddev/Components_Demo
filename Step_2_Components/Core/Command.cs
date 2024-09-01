namespace Components_Demo;

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
        var handlers = cmd.Components.Get_All<IHandler<T>>().ToArray();
        var action = () => { };
        foreach (var handler in handlers)
            action = () => handler.Handle(cmd, action);
        action();
    }
}
