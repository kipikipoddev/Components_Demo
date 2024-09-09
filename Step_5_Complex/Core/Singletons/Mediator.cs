namespace Step_5_Complex;

public static class Mediator
{
    private static readonly List<Handler_Data> handlers = [];
    private static readonly List<Validator_Data> validators = [];

    public static void Add_Handler<T>(IHandler<T> handler)
        where T : Command
    {
        handlers.Add(new Handler_Data(handler, typeof(T), c => handler.Handle((T)c)));
    }

    public static void Add_Validator<T>(IValidator<T> validate)
        where T : Command
    {
        validators.Add(new Validator_Data(validate, typeof(T), c => validate.Is_Valid((T)c)));
    }

    public static void Send(Command command)
    {
        foreach (var handler in Get_Data(handlers, command))
            handler.Action(command);
    }

    public static bool Validate(Command command)
    {
        foreach (var validator in Get_Data(validators, command))
            if (!validator.Function(command))
                return false;
        return true;
    }

    public static void Remove(IComponent component)
    {
        Remove_Data(handlers, component);
        Remove_Data(validators, component);
    }

    private static IEnumerable<T> Get_Data<T>(List<T> data_list, Command command)
        where T : Data
    {
        var types = Get_Base_Types(command.GetType());
        foreach (var data in data_list)
            if (data.Component.Parent == command.Components && types.Contains(data.Type))
                yield return data;
    }

    private static void Remove_Data<T>(List<T> data_list, IComponent component)
        where T : Data
    {
        for (int i = 0; i < data_list.Count; i++)
            if (data_list[i].Component == component)
                data_list.RemoveAt(i);
    }

    private static IEnumerable<Type> Get_Base_Types(Type type)
    {
        while (type != typeof(object))
        {
            yield return type;
            type = type.BaseType;
        }
    }

    private record Handler_Data(IComponent Component, Type Type, Action<Command> Action)
        : Data(Component, Type)
    { }
    private record Validator_Data(IComponent Component, Type Type, Func<Command, bool> Function)
        : Data(Component, Type)
    { }
    private record Data(IComponent Component, Type Type) { }
}
