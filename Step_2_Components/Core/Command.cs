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
        var handlers = Get_Handlers(cmd);
        var action = () => { };
        foreach (var handler in handlers)
            action = () => handler.Handle(cmd, action);
        action();
    }

    private static IEnumerable<IHandler<T>> Get_Handlers<T>(T cmd)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>();
        foreach (var handler in handlers)
            yield return handler;
        if (typeof(T).BaseType != null)
        {
            var handler_type = typeof(IHandler<>).MakeGenericType(typeof(T).BaseType!);
            var base_handlers = cmd.Components.Get_All(handler_type);
            foreach (var handler in base_handlers)
                yield return (IHandler<T>)handler;
        }
    }
}
