using System.Reflection;

namespace Components_Demo;

public abstract class Command
{
    private static MethodInfo action_method;

    public IComponents Components { get; }

    public Command(IComponents components)
    {
        Components = components;
        if (action_method == null)
            action_method = typeof(Command).GetMethod("Get_Action", BindingFlags.Static | BindingFlags.NonPublic)!;
    }

    public static void Send<T>(T cmd)
        where T : Command
    {
        var action = () => { };
        action = Get_Action(cmd, action);
        action = Get_Base(cmd, action);
        action();
    }

    private static Action Get_Action<T>(T cmd, Action action)
        where T : Command
    {
        var handlers = cmd.Components.Get_All<IHandler<T>>();
        foreach (var handler in handlers)
            action = () => handler.Handle(cmd, action);
        return action;
    }

    private static Action Get_Base(Command cmd, Action action)
    {
        var base_type = cmd.GetType().BaseType;
        if (base_type != null)
        {
            var gen_method = action_method.MakeGenericMethod(base_type);
            return (Action)gen_method.Invoke(null, [cmd, action])!;
        }
        return action;
    }
}
