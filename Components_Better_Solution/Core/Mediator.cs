
using System.Reflection;

namespace Components_Better_Solution;

public static class Mediator
{
    private static MethodInfo handle_method;
    private static MethodInfo has_handler_method;
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
            return false;
        var gen_method = has_handler_method.MakeGenericMethod(type!);
        return (bool)gen_method.Invoke(null, [cmd]);
    }

    private static void Send_Type(Command cmd, Type type)
    {
        if (type == null || type == typeof(object))
            return;
        var gen_method = handle_method.MakeGenericMethod(type!);
        gen_method.Invoke(null, [cmd]);
    }

    private static void Handle_Gen<T>(T cmd)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>().ToArray();
        foreach (var handler in handlers)
            handler.Handle(cmd);
    }

    private static bool Has_Handler_Gen<T>(T cmd)
        where T : Command
    {
        return cmd.Components.Has<IHandler<T>>();
    }

    private static void Init()
    {
        if (handle_method != null)
            return;
        handle_method = typeof(Mediator).GetMethod("Handle_Gen", BindingFlags.Static | BindingFlags.NonPublic)!;
        has_handler_method = typeof(Mediator).GetMethod("Has_Handler_Gen", BindingFlags.Static | BindingFlags.NonPublic)!;
    }
}
