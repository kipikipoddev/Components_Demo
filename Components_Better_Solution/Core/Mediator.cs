
using System.Reflection;

namespace Components_Better_Solution;

public static class Mediator
{
    private static MethodInfo handle_method;
    public static void Send(Command cmd)
    {
        Init();
        Send_Gen(cmd, cmd.GetType());
    }

    public static bool Is_Valid<T>(T cmd)
        where T : Command
    {
        var validators = cmd.Components.Get_All<IValidator<T>>();
        foreach (var validator in validators)
            if (!validator.Is_Valid(cmd))
                return false;
        return true;
    }

    private static void Send_Gen(Command cmd, Type type)
    {
        if (type == null || type == typeof(object))
            return;
        var gen_method = handle_method.MakeGenericMethod(type!);
        gen_method.Invoke(null, [cmd]);
    }

    private static void Handle_Gen<T>(T cmd)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>();
        foreach (var handler in handlers)
            handler.Handle(cmd);
    }

    private static void Init()
    {
        if (handle_method == null)
        {
            handle_method = typeof(Mediator).GetMethod("Handle_Gen", BindingFlags.Static | BindingFlags.NonPublic)!;
            //validate_method = typeof(Mediator).GetMethod("Validate_Command", BindingFlags.Static | BindingFlags.NonPublic)!;
        }
    }
}
