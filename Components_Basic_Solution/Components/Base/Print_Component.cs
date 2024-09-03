
namespace Components_Basic_Solution;

public abstract class Print_Component : Component, IPrint_Component
{
    protected abstract void Print(string message);

    public void Print_Was(Actions action)
    {
        Print("was", action);
    }

    public void Print_Cant(Actions action)
    {
        Print("can't", action);
    }

    private void Print(string middle, Actions action)
    {
        var name = Parent.Get<IName_Component>().Name;
        var action_str = action.ToString().ToLower();
        Print($"{name} {middle} {action_str}");
    }
}