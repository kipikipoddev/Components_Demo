
namespace Components_Demo;

public abstract class Action_Printer : IAction_Printer
{
    protected abstract void Print(string message);

    public void Print_Action(IEntity entity, Actions action)
    {
        Print($"{entity.Name} was {To_String(action)}");
    }

    public void Print_Cannot(IEntity entity, Actions action)
    {
        Print($"{entity.Name} cannot {To_String(action)}");
    }

    public void Print_Actions(IEntity entity)
    {
        var actions = entity.Get_Actions();
        if (actions.Any())
            Print(entity.Name + " can: " + To_String(actions));
        else
            Print(entity.Name + " cannot do anything");
    }

    private static string To_String(IEnumerable<Actions> actions)
    {
        var strings = actions.Select(To_String).ToArray();
        if (strings.Length == 1)
            return strings[0];
        if (strings.Length == 2)
            return string.Join(" and ", strings);
        return string.Join(", ", strings, 0, strings.Length - 1) + " and " + strings[^1];
    }

    private static string To_String(Actions action)
    {
        return action.ToString().ToLower();
    }
}