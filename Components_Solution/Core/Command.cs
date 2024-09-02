using System.Data.SqlTypes;
using System.Reflection;

namespace Components_Solution;

public abstract class Command
{
    private static MethodInfo send_method;
    public static Action Defualt_Action = () => { };

    public IComponents Components { get; }

    public Command(IComponents components)
    {
        Components = components;
        if (send_method == null)
            send_method = typeof(Command).GetMethod("Get_Action", BindingFlags.Static | BindingFlags.NonPublic)!;
    }

    public static void Send<T>(T cmd)
        where T : Command
    {
        var action = Defualt_Action;
        action = Get_Action(cmd, action);
        action = Get_Base(cmd, cmd.GetType().BaseType, action);
        if (action != null)
            action();
    }

    private static Action Get_Action<T>(T cmd, Action action)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>();
        foreach (var handler in handlers)
            action = Get_Handler_Action(cmd, action, handler);
        return action;
    }

    private static Action Get_Base(Command cmd, Type? type, Action action)
    {
        if (type != typeof(object))
        {
            var gen_method = send_method.MakeGenericMethod(type);
            action = (Action)gen_method.Invoke(null, [cmd, action]);
            Get_Base(cmd, type.BaseType, action);
        }
        return action;
    }

    private static Action Get_Handler_Action<T>(T cmd, Action action, IHandler<T> handler)
        where T : Command
    {
        return () => handler.Handle(cmd, action);
    }
}
