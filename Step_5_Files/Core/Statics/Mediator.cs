namespace Step_5_Files.Core;

public static class Mediator
{
    private static readonly List<Handler_Data> handlers = new();

    public static void Add<TEvent>(IHandler<TEvent> handler, object? @object = null)
        where TEvent : Event
    {
        Remove(handler);
        var data = new Handler_Data(
            typeof(TEvent),
            handler,
            @object,
            e => handler.Handle((TEvent)e));
        handlers.Add(data);
    }

    public static void Remove<TEvent>(IHandler<TEvent> handler)
        where TEvent : Event
    {
        for (int i = 0; i < handlers.Count; i++)
            if (handlers[i].handler == handler && handlers[i].Type == typeof(TEvent))
                handlers.RemoveAt(i);
    }

    public static void Send(Event evnt)
    {
        var handlers_action = handlers
            .Where(h => h.Type == evnt.GetType() & h.Object == evnt.Object)
            .Select(h => h.Action).Reverse().ToArray();
        foreach (var handler in handlers_action)
            handler(evnt);
    }

    record Handler_Data(Type Type, object handler, object? Object, Action<object> Action) { }
}