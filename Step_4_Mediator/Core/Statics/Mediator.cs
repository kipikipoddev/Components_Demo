namespace Step_4_Mediator.Core;

public static class Mediator
{
    private static readonly List<Listener_Data> listeners = new();

    public static void Add<TEvent>(IListener<TEvent> listener, object? model = null)
        where TEvent : Event
    {
        Remove(listener);
        var data = new Listener_Data(typeof(TEvent), listener, model, e => listener.Handle((TEvent)e));
        listeners.Add(data);
    }

    public static void Remove<TEvent>(IListener<TEvent> listener)
        where TEvent : Event
    {
        for (int i = 0; i < listeners.Count; i++)
            if (listeners[i].Listener == listener && listeners[i].Type == typeof(TEvent))
                listeners.RemoveAt(i);
    }

    public static void Send(Event evnt)
    {
        var listeners_action = listeners.Where(h => h.Type == evnt.GetType() && h.Model == evnt.Model_Object)
            .Select(h => h.Action).Reverse().ToArray();
        foreach (var listener in listeners_action)
            listener(evnt);
    }

    record Listener_Data(Type Type, object Listener, object? Model, Action<object> Action) { }
}