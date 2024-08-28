namespace Step_5_Files.Core;

public static class Mediator
{
    private static readonly List<Handler_Data> handlers = [];

    public static void Add<TEvent>(IHandler<TEvent> handler, object? @object = null)
        where TEvent : Event
    {
        var data = new Handler_Data(
            typeof(TEvent),
            @object,
            e => handler.Handle((TEvent)e));
        handlers.Add(data);
    }

    public static void Add(IHandler handler, object? @object = null)
    {
        var data = new Handler_Data(
            null,
            @object,
            e => handler.Handle(e));
        handlers.Add(data);
    }


    public static void Send(Event cmd)
    {
        foreach (var handler in Get_Handlers(cmd))
            handler(cmd);
    }

    private static IEnumerable<Action<Event>> Get_Handlers(Event cmd)
    {
        return handlers
            .Where(h => Is_Relevent(cmd, h))
            .Select(h => h.Action);
    }

    private static bool Is_Relevent(Event cmd, Handler_Data data)
    {
        return (data.Type == null || data.Type == cmd.GetType()) & data.Object == cmd.Object;
    }

    record Handler_Data(Type? Type, object? Object, Action<Event> Action) { }
}