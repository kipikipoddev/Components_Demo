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
        var handlers_action = handlers
            .Where(h => h.Type == evnt.GetType() & h.Object == evnt.Object)
            .Select(h => h.Action).Reverse().ToArray();
        foreach (var handler in handlers_action)
            handler(evnt);
    }

    record Handler_Data(Type Type, object? Object, Action<object> Action) { }
}