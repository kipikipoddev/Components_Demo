
using System.Reflection;

namespace Components_Better_Solution;

public static class Mediator
{
    private static MethodInfo handle_method;
    private static MethodInfo is_valid_method;

    public static void Send(Command cmd)
    {
        Init();
        Send_Type(cmd, cmd.GetType());
    }

    public static bool Is_Valid(Command cmd)
    {
        Init();
        return Is_Valid_Type(cmd, cmd.GetType());
    }

    private static bool Is_Valid_Type(Command cmd, Type type)
    {
        if (type == null || type == typeof(object))
            return true;
        var gen_method = is_valid_method.MakeGenericMethod(type!);
        var is_valid = (bool)gen_method.Invoke(null, [cmd]);
        if (!is_valid)
            return false;
        return Is_Valid_Type(cmd, type.BaseType);
    }

    private static void Send_Type(Command cmd, Type type)
    {
        if (type == null || type == typeof(object))
            return;
        var gen_method = handle_method.MakeGenericMethod(type!);
        gen_method.Invoke(null, [cmd]);
        Send_Type(cmd, type.BaseType);
    }

    private static void Handle_Gen<T>(T cmd)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>().ToArray();
        foreach (var handler in handlers)
            handler.Handle(cmd);
    }

    private static bool Is_Valid_Gen<T>(T cmd)
        where T : Command
    {
        var validators = cmd.Components.Get_All<IValidator<T>>().ToArray();
        foreach (var validator in validators)
            if (!validator.Is_Valid(cmd))
                return false;
        return true;
    }

    private static void Init()
    {
        if (handle_method != null)
            return;
        handle_method = typeof(Mediator).GetMethod("Handle_Gen", BindingFlags.Static | BindingFlags.NonPublic)!;
        is_valid_method = typeof(Mediator).GetMethod("Is_Valid_Gen", BindingFlags.Static | BindingFlags.NonPublic)!;
    }
}
