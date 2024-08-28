using Step_4_Commands.Commands;

namespace Step_4_Commands;

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
        var handlers = cmd.Components.Get_All<IHandler<T>>();
        foreach (var handler in handlers)
            handler.Handle(cmd);
        if (!handlers.Any())
            new No_Handler_Command( cmd);
    }
}