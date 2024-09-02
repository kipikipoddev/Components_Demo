using System.Reflection;

namespace Components_Solution;

public static class Mediator
{
    private static MethodInfo send_method;
    private static MethodInfo validate_method;

    public static void Send<T>(T cmd)
        where T : Command
    {
        Init();
        if (!Is_Valid(cmd))
            new No_Handler_Command(cmd);
        else
        {
            var handled = Send_Command(cmd);
            handled |= Send_Base(cmd, cmd.GetType().BaseType);
            if (!handled)
                new No_Handler_Command(cmd);
        }
    }

    public static bool Is_Valid<T>(T cmd)
        where T : Command
    {
        Init();
        if (!Is_Command_Valid(cmd))
            return false;
        return Is_Base_Command_Valid(cmd, cmd.GetType().BaseType);
    }

    private static void Init()
    {
        if (send_method == null)
        {
            send_method = typeof(Mediator).GetMethod("Send_Command", BindingFlags.Static | BindingFlags.NonPublic)!;
            validate_method = typeof(Mediator).GetMethod("Is_Command_Valid", BindingFlags.Static | BindingFlags.NonPublic)!;
        }
    }


    private static bool Send_Command<T>(T cmd)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>();
        foreach (var handler in handlers)
            handler.Handle(cmd);
        return handlers.Any();
    }

    private static bool Is_Command_Valid<T>(T cmd)
        where T : Command
    {
        var validators = cmd.Components.Get_All<IValidator<T>>();
        foreach (var validator in validators)
            if (!validator.Is_Valid(cmd))
                return false;
        return true;
    }

    private static bool Send_Base(Command cmd, Type? type)
    {
        if (type != typeof(object))
        {
            var gen_method = send_method.MakeGenericMethod(type);
            var has = (bool)gen_method.Invoke(null, [cmd]);
            return has | Send_Base(cmd, type.BaseType);
        }
        return false;
    }

    private static bool Is_Base_Command_Valid(Command cmd, Type? type)
    {
        if (type != typeof(object))
        {
            var gen_method = validate_method.MakeGenericMethod(type);
            if (!(bool)gen_method.Invoke(null, [cmd]))
                return false;
            return Is_Base_Command_Valid(cmd, type.BaseType);
        }
        return true;
    }
}
