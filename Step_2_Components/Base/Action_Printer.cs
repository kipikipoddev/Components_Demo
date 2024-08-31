
namespace Components_Demo;

public abstract class Action_Printer : IAction_Printer
{
    protected abstract void Print(string message);

    public void Print_Action(IAction_Component action, bool add_speed = false)
    {
        var speed_str = add_speed ? To_String(action.Parent.Speed()) : string.Empty;
        Print($"{action.Parent.Name()} is {action.Doing}{speed_str}");
    }

    public void Print_Cannot(IAction_Component action)
    {
        Print($"{action.Parent.Name()} cannot {action.Name}");
    }

    public void Print_Actions(IComponents components)
    {
        var actions = components.Get_All<IAction_Component>()
            .Select(a => a.Name).ToArray();
        if (actions.Any())
            Print(components.Name() + " can: " + To_String(actions));
        else
            Print(components.Name() + " cannot do anything");
    }

    private static string To_String(string[] actions)
    {
        if (actions.Length == 1)
            return actions[0];
        if (actions.Length == 2)
            return string.Join(" and ", actions);
        return string.Join(", ", actions, 0, actions.Length - 1) + " and " + actions[^1];
    }

    private static string To_String(Speed speed)
    {
        switch (speed)
        {
            case Speed.Slow:
                return " slowly";
            case Speed.Fast:
                return " fast";
            default:
                return string.Empty;
        }
    }
}