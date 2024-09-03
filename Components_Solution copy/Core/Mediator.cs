using System.Reflection;

namespace Components_Solution;

public static class Mediator
{
    private static MethodInfo send_method;
    private static MethodInfo validate_method;

    public static bool Is_Valid(Command cmd)
    {
        Init();
        return Validate_Gen_Command(cmd, cmd.GetType());
    }

    public static void Send(Command cmd)
    {
        Init();
        Send_Gen_Command(cmd, cmd.GetType());
    }

    private static void Send_Gen_Command(Command cmd, Type? type)
    {
        if (type == null || type == typeof(object))
            return;
        var gen_method = send_method.MakeGenericMethod(type!);
        gen_method.Invoke(null, [cmd]);
        Send_Gen_Command(cmd, type.BaseType);
    }

    private static bool Validate_Gen_Command(Command cmd, Type? type)
    {
        if (type == null || type == typeof(object))
            return true;
        var gen_method = validate_method.MakeGenericMethod(type!);
        var result = gen_method.Invoke(null, [cmd]);
        if (!(bool)result)
            return false;
        return Validate_Gen_Command(cmd, type.BaseType);
    }

    private static void Send_Command<T>(T cmd)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>();
        foreach (var handler in handlers)
            handler.Handle(cmd);
    }

    private static bool Validate_Command<T>(T cmd)
        where T : Command
    {
        var validators = cmd.Components.Get_All<IValidator<T>>();
        foreach (var validator in validators)
            if (!validator.Is_Valid(cmd))
                return false;
        return true;
    }

    private static void Init()
    {
        if (send_method == null)
        {
            send_method = typeof(Mediator).GetMethod("Send_Command", BindingFlags.Static | BindingFlags.NonPublic)!;
            validate_method = typeof(Mediator).GetMethod("Validate_Command", BindingFlags.Static | BindingFlags.NonPublic)!;
        }
    }
}
