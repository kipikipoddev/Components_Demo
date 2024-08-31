
namespace Step_1_OOP;

public abstract class Action_Printer : IAction_Printer
{
    protected abstract void Print(string message);

    public void Print_Action(IEntity entity, object message, bool add_speed, string? extra = null)
    {
        var speed = add_speed ? Get_Speed(entity.Speed) : string.Empty;
        Print($"{entity.Name} is {message.ToString()!.ToLower()} {speed}{extra ?? string.Empty}");
    }

    public void Print_Cannot(IEntity entity, object message)
    {
        Print($"{entity.Name} cannot {message.ToString()!.ToLower()}");
    }

    public void Print_Actions(IEntity entity)
    {
        var actions = Get_Actions(entity);
        if (actions.Any())
            Print(entity.Name + " can: " + Actions_To_string(actions));
        else
            Print(entity.Name + " cannot do anything");
    }

    private static IEnumerable<Actions> Get_Actions(IEntity entity)
    {
        if (entity.Can_Walk)
            yield return Actions.Walk;
        if (entity.Can_Make_Sound)
            yield return Actions.Make_Sound;
        if (entity.Can_Swim)
            yield return Actions.Swim;
    }

    private static string Actions_To_string(IEnumerable<Actions> actions)
    {
        var strings = actions
            .Select(a => a.ToString().ToLower().Replace('_', ' '))
            .ToArray();
        return Actions_To_string(strings);
    }

    private static string Actions_To_string(string[] actions)
    {
        if (actions.Length == 1)
            return actions[0];
        if (actions.Length == 2)
            return string.Join(" and ", actions);
        return string.Join(", ", actions, 0, actions.Length - 1) + " and " + actions[^1];
    }

    private static string Get_Speed(Speed speed)
    {
        switch (speed)
        {
            case Speed.Slow:
                return "slowly";
            case Speed.Fast:
                return "fast";
            default:
                return string.Empty;
        }
    }
}