namespace Step_4_Mediator.Core;

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

    public static void Send(Event evnt)
    {
        foreach (var handler in Get_Handlers(evnt))
            handler(evnt);
    }

    private static IEnumerable<Action<Event>> Get_Handlers(Event evnt)
    {
        return handlers
            .Where(h => Is_Relevent(evnt, h))
            .Select(h => h.Action);
    }

    private static bool Is_Relevent(Event evnt, Handler_Data data)
    {
        return data.Type == evnt.GetType() & data.Object == evnt.Object;
    }

    record Handler_Data(Type Type, object? Object, Action<Event> Action) { }
}