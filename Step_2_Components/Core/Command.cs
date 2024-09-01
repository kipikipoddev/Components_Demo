using System.Data.SqlTypes;
using System.Reflection;

namespace Components_Demo;

public abstract class Command
{
    private static MethodInfo send_method;

    public IComponents Components { get; }

    public Command(IComponents components)
    {
        Components = components;
        if (send_method == null)
            send_method = typeof(Command).GetMethod("Send_Command", BindingFlags.Static | BindingFlags.NonPublic)!;
    }

    public static void Send<T>(T cmd)
        where T : Command
    {
        var token = new Cancel_Token();
        Send_Base(cmd, cmd.GetType().BaseType, token);
        Send_Command(cmd, token);
    }

    private static void Send_Command<T>(T cmd, Cancel_Token token)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>();
        foreach (var handler in handlers)
            if (!token.Is_Canceled)
                handler.Handle(cmd, token);
    }

    private static void Send_Base(Command cmd, Type? type, Cancel_Token token)
    {
        if (type != typeof(object))
        {
            var gen_method = send_method.MakeGenericMethod(type);
            gen_method.Invoke(null, [cmd, token]);
            Send_Base(cmd, type.BaseType, token);
        }
    }
}
