
namespace Components_Demo;

public abstract class Action_Printer : IAction_Printer
{
    private readonly IEntity entity;

    protected abstract void Print(string message);

    public Action_Printer(IEntity entity)
    {
        this.entity = entity;
    }

    public void Print_Action(IAction action, bool add_speed = false)
    {
        var speed_str = add_speed ? To_String(entity.Speed) : string.Empty;
        Print($"{entity.Name} is {action.Doing}{speed_str}");
    }

    public void Print_Cannot(IAction action)
    {
        Print($"{entity.Name} cannot {action.Name}");
    }

    public void Print_Actions()
    {
        var actions = entity.Actions.Select(a => a.Name).ToArray();
        if (actions.Any())
            Print(entity.Name + " can: " + To_String(actions));
        else
            Print(entity.Name + " cannot do anything");
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