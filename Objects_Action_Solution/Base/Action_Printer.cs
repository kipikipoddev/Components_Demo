
namespace Objects_Solution;

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

    private static string To_String(Actions action)
    {
        return action.ToString().ToLower();
    }
}