namespace Components_Better_Solution;

public static class Mediator
{
    public static void Send<T>(T cmd)
        where T : Command
    {
        var handler = cmd.Components.Get<IHandler<T>>();
        handler.Handle(cmd);
    }
}
