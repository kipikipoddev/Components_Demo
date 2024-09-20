namespace Step_4_Files;

public static class Mediator
{
    private static readonly List<Handler_Data> handlers = [];

    public static void Add_Handler<T>(IHandler<T> handler)
        where T : Command
    {
        handlers.Add(new Handler_Data(handler, typeof(T), c => handler.Handle((T)c)));
    }

    public static void Send(Command command)
    {
        foreach (var handler in Get_Data(command))
            handler.Handler(command);
    }

    private static IEnumerable<Handler_Data> Get_Data(Command command)
    {
        var types = Get_Base_Types(command.GetType());
        foreach (var data in handlers)
            if (data.Component.Parent == command.Components && types.Contains(data.Type))
                yield return data;
    }

    private static IEnumerable<Type> Get_Base_Types(Type type)
    {
        while (type != typeof(object))
        {
            yield return type;
            type = type.BaseType;
        }
    }

    private record Handler_Data(IComponent Component, Type Type, Action<Command> Handler) { }
}
