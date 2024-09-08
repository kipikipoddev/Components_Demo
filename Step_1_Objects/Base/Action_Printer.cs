
namespace Step_1_Objects;

public abstract class Action_Printer : IAction_Printer
{
    protected abstract void Print(string message);

    public void Print_Action(IEntity entity, Actions action)
    {
        Print($"{entity.Name} was {To_String(action)}");
    }

    public void Print_Cant(IEntity entity, Actions action)
    {
        Print($"{entity.Name} can't {To_String(action)}");
    }

    private static string To_String(Actions action)
    {
        return action.ToString().ToLower();
    }
}