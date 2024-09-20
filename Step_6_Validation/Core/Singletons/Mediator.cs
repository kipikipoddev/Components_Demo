namespace Step_6_Validation;

public static class Mediator
{
    private static readonly List<Handler_Data> handlers = [];
    private static readonly List<Validator_Data> validators = [];

    public static void Add_Handler<T>(IHandler<T> handler)
        where T : Command
    {
        handlers.Add(new Handler_Data(handler, typeof(T), c => handler.Handle((T)c)));
    }

    public static void Add_Validator<T>(IValidator<T> validator)
        where T : Command
    {
        validators.Add(new Validator_Data(validator, typeof(T), c => validator.Is_Valid((T)c)));
    }

    public static void Send(Command command)
    {
        foreach (var handler in Get_Data(handlers, command))
            handler.Handle(command);
    }

    public static bool Is_Valid(Command command)
    {
        foreach (var validator in Get_Data(validators, command))
            if (!validator.Is_Valid(command))
                return false;
        return true;
    }

    private static IEnumerable<T> Get_Data<T>(List<T> list, Command command)
        where T : Base_Data
    {
        var types = Get_Base_Types(command.GetType());
        foreach (var data in list)
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

    private record Handler_Data(IComponent Component, Type Type, Action<Command> Handle) : Base_Data(Component, Type) { }
    private record Validator_Data(IComponent Component, Type Type, Func<Command, bool> Is_Valid) : Base_Data(Component, Type) { }
    private record Base_Data(IComponent Component, Type Type) { }
}
