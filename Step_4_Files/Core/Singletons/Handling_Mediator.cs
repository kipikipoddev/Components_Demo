
using System.Reflection;

namespace Step_4_Files;

public static class Handling_Mediator
{
    private static MethodInfo method;

    public static void Send(Command cmd)
    {
        Init();
        Send_Type(cmd, cmd.GetType());
    }

    private static void Send_Type(Command cmd, Type type)
    {
        if (type == null || type == typeof(object))
            return;
        var gen_method = method.MakeGenericMethod(type!);
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

    private static void Init()
    {
        if (method == null)
            method = typeof(Handling_Mediator).GetMethod("Handle_Gen", BindingFlags.Static | BindingFlags.NonPublic)!;
    }
}
